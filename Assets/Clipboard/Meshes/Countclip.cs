using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countclip : MonoBehaviour
{
  public  GameObject Item1;
    public GameObject Item2;
    public int all_zapiski = 5;
    public Text zapiski;
    // Start is called before the first frame update
    void Start()
    {
        zapiski.text = "записки - " + all_zapiski;

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
         
                    zapiski.text = "записки - " + (all_zapiski - countitem);
        } 
    }
}
