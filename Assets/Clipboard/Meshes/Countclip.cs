using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countclip : MonoBehaviour
{
  public  GameObject Item1;
    public GameObject Item2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //// Update is called once per frame
    void Update()
    {
        

    }

    private int countitem = 0;

    public int Countitem
    { get => countitem;
        set
        { countitem = value; if (Countitem >= 5)
                Debug.Log("EndGame");
            Destroy(Item1.gameObject);
            Destroy(Item2.gameObject);
        } 
    }
}
