using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBeatSound : MonoBehaviour
{
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }
  public   void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            Debug.Log("Запуск");
            audio.UnPause();
        }
     
    
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag != "player")
        {
            Debug.Log("Остановка");
            audio.Pause();
        }

    }
    //void OnCollisionEnter(Collision col)
    //{

    //    if (col.transform.tag == "player")
    //    {

    //        GetComponent<AudioSource>().UnPause();
    //    }
    //    else
    //    {
    //        GetComponent<AudioSource>().Pause();
    //    }


    //    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
