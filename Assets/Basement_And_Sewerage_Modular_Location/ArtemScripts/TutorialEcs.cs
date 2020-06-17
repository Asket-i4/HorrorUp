using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialEcs : MonoBehaviour
{

    public GameObject Tutorial1;
    public GameObject Tutorial2;
    public GameObject Tutorial3;
    public GameObject Tutorial4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("SSS");

            Tutorial1.SetActive(false);
            Tutorial2.SetActive(true);
            Tutorial3.SetActive(false);
            Tutorial4.SetActive(false);

        }
       
    }
}
