using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class Smena : MonoBehaviour
{
    bool position = true;
    bool karutina = true;
    public GameObject gun;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
            if (karutina )
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    if (position)
                    {
                        GameObject.Find("Main Camera").GetComponent<Faer>().enabled = false;
                        gun.SetActive(false);
                        GameObject.Find("NewFPSControl").GetComponent<DragRigidbody>().enabled = true;
                        position = false;
                        karutina = false;
                        StartCoroutine(Stop());
                    }
                    else
                    {
                        GameObject.Find("Main Camera").GetComponent<Faer>().enabled = true;
                        gun.SetActive(true);
                        GameObject.Find("NewFPSControl").GetComponent<DragRigidbody>().enabled = false;
                        position = true;
                        karutina = false;
                        StartCoroutine(Stop());
                    }
                }
        
    }


    IEnumerator Stop()
    {
        yield return new WaitForSeconds(4);
        karutina = true;
    }

}
