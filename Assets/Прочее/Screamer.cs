using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Video;

public class Screamer : MonoBehaviour
{
   public VideoPlayer video;

    void Start()
    {
        video.SetDirectAudioMute(0, true);
        video.targetCameraAlpha = 0;
        video.Play();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "player")
        {
            video.SetDirectAudioMute(0, false);
            video.targetCameraAlpha = 1;
            video.Play();
            StartCoroutine(Restart());
        }
    }
    IEnumerator Restart()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
