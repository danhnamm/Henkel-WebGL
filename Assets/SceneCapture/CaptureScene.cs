using System.Collections;
using UnityEngine;
using System.Runtime.InteropServices;

public class CaptureScene : MonoBehaviour
{
    public static CaptureScene Instant;    
    private Texture2D ss;
    [SerializeField] private RectTransform _objToScreenshot;

    [DllImport("__Internal")]
    private static extern void DownloadFile(byte[] array, int byteLength, string fileName);
    [DllImport("__Internal")]
    private static extern void RequestedConfirmNative();

    private void Awake()
    {
        if (Instant == null) { Instant = this; }
        else { Destroy(this); }
    }    
    public void ConfirmRequest() { if (Application.platform == RuntimePlatform.WebGLPlayer) RequestedConfirmNative(); }
    public void Capture()
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer) { StartCoroutine(TakeSnapShotAndSave()); }
    }
    public IEnumerator TakeSnapShotAndSave()
    {        
        yield return new WaitForEndOfFrame();//Code will throw error at runtime if this is removed

        //Get the corners of RectTransform rect and store it in a array vector
        Vector3[] corners = new Vector3[4];
        _objToScreenshot.GetWorldCorners(corners);

        //Remove 100 and you will get error
        int width = ((int)corners[3].x - (int)corners[0].x);
        int height = (int)corners[1].y - (int)corners[0].y;
        var startX = corners[0].x;
        var startY = corners[0].y;

        //Make a temporary texture and read pixels from it
        ss = new Texture2D(width, height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(startX, startY, width, height), 0, 0);
        ss.Apply();                

        //send to native (downloading)
        byte[] byteArray = ss.EncodeToPNG();

        DownloadFile(byteArray, byteArray.Length, "VnPay_" + Time.time + ".png");
    }    
}

public class ApiResult
{
    public int StatusCode;
    public string StatusDesc;
    public string url;
}