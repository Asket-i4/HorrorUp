using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_Iventory : MonoBehaviour
{
    public Animator anim;
    public int number = 0;
    public Transform trigger;
    public bool IsOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && IsOpen == false)
        {

            anim.SetBool("isFade", true);
            Debug.Log("TRUE");
            IsOpen = true;
            // StartCoroutine(LoadScene());
            // Destroy(infoMenuUI);
            //


            // anim.SetBool("isFade", false);
            //  Debug.Log("FALSE");

        }
        if (IsOpen == true)
        {
            number++;

            if (number > 100)
            {
                IsOpen = false;
                number = 0;
                anim.SetBool("isFade", false);
                Debug.Log("FALSE");
            }
        }
    }
}
