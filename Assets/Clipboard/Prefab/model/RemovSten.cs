using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RemovSten : MonoBehaviour
{
    public GameObject newsten;
    public GameObject Axe;

    int heal = 3;
    bool karutina = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerStay(Collider otehr)
    {
        if (otehr.gameObject.tag == "player" & Input.GetMouseButtonDown(0) & Axe.gameObject.active & karutina)
        {
            heal--;
            if (heal <= 0)
            {
                RemovItem();
                return;
            }
            karutina = false;
            StartCoroutine(Stop());

        }


    }

    void RemovItem()
    {
        this.newsten.SetActive(true);
        Destroy(this.gameObject);
    }


    IEnumerator Stop()
    {
        yield return new WaitForSeconds(3);
        karutina = true;
    }
}
