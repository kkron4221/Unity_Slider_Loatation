using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderDemo : MonoBehaviour
{
    public void SliderDemo_CubeRot(float newValue)
    {
        Vector3 rot = this.transform.localEulerAngles;

        rot.y = newValue;

        this.transform.localEulerAngles = rot;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
