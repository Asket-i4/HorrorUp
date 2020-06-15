using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBattery : MonoBehaviour
{
   

    void OnTriggerStay(Collider otehr)
    {
        if (otehr.gameObject.tag == "player" )
        {

            Debug.Log(1212);
        }

        if (otehr.gameObject.tag == "player" & Input.GetKeyDown(KeyCode.E))
        {
            GameObject.Find("Main Camera").GetComponent<Faer>().CountMagazin++;
            Destroy(gameObject);
        }
    }
}
