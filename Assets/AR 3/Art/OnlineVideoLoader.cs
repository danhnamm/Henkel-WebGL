using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class OnlineVideoLoader : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public string videoUrlVi = "yourvideourl";
    public string videoUrlen = "yourvideourl";
    // Start is called before the first frame update
    public void Vi()
    {
        videoPlayer.url = videoUrlVi;
        
    }
    public void En()
    {
        videoPlayer.url = videoUrlen;
       
    }

    public void TriggerAllVideos() {
        PrepareVideo();
        Debug.Log("Video is prepared: "+ videoPlayer.gameObject.name);
    }
   public void PrepareVideo()
    {
        if (videoPlayer.isPrepared == false)
        {

            videoPlayer.Prepare();

            Invoke("PrepareVideo", Time.deltaTime);
        }        
        else
        {
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
            }
            else
            {
                videoPlayer.Play();
                Invoke("PrepareVideo", Time.deltaTime);
            }            
        }        
    }
    public void PlayVideo()
    {
        if (videoPlayer.isPlaying == false)
        {
            videoPlayer.frame = 0;
            videoPlayer.Play();
            Invoke("PlayVideo", Time.deltaTime);
        }        
    }
}