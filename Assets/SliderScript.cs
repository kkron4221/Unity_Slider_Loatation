using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 1;
    }

    
    // Update is called once per frame
    void Update()
    {
        if (slider.value == 0)
        {
            Debug.Log("Nothing");
        }
        else
        {
            Debug.Log("Something");
        }
    }
}
