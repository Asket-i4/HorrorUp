using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameVin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay(Collider otehr)
    {
        if (otehr.gameObject.tag == "player" )
        {
            SceneManager.LoadScene(0);

        }


    }
}
