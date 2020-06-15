using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nakaut : MonoBehaviour
{
    bool chek = true;
    float a;

    // Стан бота 
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "pula" & chek)
        {
            a = gameObject.GetComponent<NavMeshAgent>().speed;
            gameObject.GetComponent<NavMeshAgent>().speed = 0;
            gameObject.GetComponent<Screamer>().enabled = false;
            Destroy(other.gameObject);
            StartCoroutine(RePover());
        }
    }


    IEnumerator RePover()
    {
        yield return new WaitForSeconds(8);
        chek = true;
        gameObject.GetComponent<NavMeshAgent>().speed = a;
        gameObject.GetComponent<Screamer>().enabled = true;
    }
}
