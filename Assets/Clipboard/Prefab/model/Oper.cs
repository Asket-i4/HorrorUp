using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oper : MonoBehaviour
{
    public bool isTaserGun = false;
   
    void OnTriggerStay(Collider otehr)
    {

            if (otehr.gameObject.tag == "player" & Input.GetKeyDown(KeyCode.E))
        {
           
            if(gameObject.name == "axe")
            {
                GameObject.Find("NewFPSControl").GetComponent<Inventori>().Axe1 = true;
                Destroy(gameObject);
            }

            if (gameObject.name == "TaserGun")
            {
                isTaserGun = true;
                GameObject.Find("NewFPSControl").GetComponent<Inventori>().Gun1 = true;
                Destroy(gameObject);
            }
        }

       
    }
}
