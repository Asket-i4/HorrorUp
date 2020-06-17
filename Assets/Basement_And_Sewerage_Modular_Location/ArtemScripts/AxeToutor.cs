using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeToutor : MonoBehaviour
{
    public GameObject pickup;
    public GameObject AxeTutor;
    public GameObject ShockerTutor;

    public GameObject Shocker;
    public GameObject ShockerUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerStay(Collider otehr)
    {
        if (otehr.gameObject.tag == "player")
        {
            pickup.SetActive(true);
            AxeTutor.SetActive(false);
        }
        if (otehr.gameObject.tag == "player" & Input.GetKeyDown(KeyCode.E))
        {
            {
                pickup.SetActive(false) ;
                ShockerTutor.SetActive(true);
                Shocker.SetActive(true);
                ShockerUI.SetActive(true);
            }
        }
    }
    void OnTriggerExit(Collider otehr)
    {
        if (otehr.gameObject.tag == "player")
        {
            pickup.SetActive(false);
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
