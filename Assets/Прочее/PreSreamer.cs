using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreSreamer : MonoBehaviour
{
    bool lost = true;
   void OnBecameVisible()
    {
        if (lost)
        {
            lost = false;
            GetComponent<AudioSource>().Play();
            StartCoroutine(timePreScreamer());
        }
    }
    IEnumerator timePreScreamer()
    {
        yield return new WaitForSeconds(15);
        lost = true;
    }
}
