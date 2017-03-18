using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeText : MonoBehaviour
{
    public GvrHead head;

	// Use this for initialization
	void Start ()
    {
        head = Camera.main.GetComponent<StereoController>().Head;
    }
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Text>().text = " " + Input.gyro.attitude.eulerAngles;

    }
}
