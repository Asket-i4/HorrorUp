using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class slider : MonoBehaviour
{
    public Slider sliderInst;
    // Start is called before the first frame update
    void Start()
    {
        sliderInst.minValue = 0;
        sliderInst.maxValue = 100;
        sliderInst.wholeNumbers = true;

    }
   public void OnValueChange(float value)
    {
        Debug.Log("NEW" + value);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
