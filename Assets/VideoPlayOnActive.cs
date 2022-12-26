using UnityEngine;

public class VideoPlayOnActive : MonoBehaviour
{
    public OnlineVideoLoader Loader;
    private void OnEnable()
    {
        Loader.PrepareVideo();
        Loader.PlayVideo();
    }
}
