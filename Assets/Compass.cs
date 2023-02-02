using UnityEngine;
using System.Collections;

public class CompassSensor : MonoBehaviour {

 void Start () {
 Input.compass.enabled = true;
 }
 
 void Update () {
 transform.rotation = Quaternion.Euler(0, Input.compass.magneticHeading, 0);
 }

}