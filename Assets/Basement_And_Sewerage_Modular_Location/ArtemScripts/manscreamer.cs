using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class manscreamer : MonoBehaviour
{
    public GameObject man;
    public AudioClip impact;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider otehr)
    {
        if (otehr.gameObject.tag == "player")
        {
            AudioSource.PlayClipAtPoint(impact, transform.position);
            man.SetActive(true);

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
