using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shockertutor : MonoBehaviour
{
    public GameObject UI;
    public GameObject TutorialShocker;
    public GameObject delete;
    public GameObject Green_Light;
    public GameObject finalTutor;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerStay(Collider otehr)
    {
        if (otehr.gameObject.tag == "player")
        {
         
        }
        if (otehr.gameObject.tag == "player" & Input.GetKeyDown(KeyCode.E))
        {
            {
                StartCoroutine(RePover());
                TutorialShocker.SetActive(true);
                UI.SetActive(true);
                delete.SetActive(false);

                finalTutor.SetActive(true);
                Green_Light.SetActive(true);
            }
        }
    }
    void OnTriggerExit(Collider otehr)
    {
        if (otehr.gameObject.tag == "player")
        {
           

        }
    }
    IEnumerator RePover()
    {
        yield return new WaitForSeconds(4);// Время ожидания в сек
       
        finalTutor.SetActive(true);
        Green_Light.SetActive(true);
    }
   
    // Update is called once per frame
  
}
