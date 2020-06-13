using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropclip : MonoBehaviour
{
   public GameObject item;
    public GameObject ItemCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  private  void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "clip")
        {
            ItemCount.GetComponent<Countclip>().Countitem++;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            item.SetActive(true);
            other.gameObject.SetActive(false);
            Destroy(other);
        }
        
    }

}
