﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movetutor : MonoBehaviour
{
    public GameObject Tutor2;
    public GameObject Tutor3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.D))
        {
            Tutor2.SetActive(false);
            Tutor3.SetActive(true);
        }
    }
}
