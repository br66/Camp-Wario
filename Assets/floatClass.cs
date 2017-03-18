using UnityEngine;
using System.Collections;

public class floatClass : MonoBehaviour
{
    public float waterLevel;
    public float floatHeight;
    public float bounceDamp;
    public Vector3 bouyancyCenterOffset;

    float forceFactor;
    Vector3 actionPoint;
    Vector3 upLift;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        // move to its position plus this offset
        actionPoint = transform.position + transform.TransformDirection(bouyancyCenterOffset);

        // apply force to point we set (Action point) by the water level in accordance to float height
        forceFactor = 1f - ((actionPoint.y - waterLevel) / floatHeight);

        if (forceFactor > 0f)
        {
            // makes the vector for bobbing up and down
            upLift = -Physics.gravity * (forceFactor - GetComponent<Rigidbody>().velocity.y * bounceDamp);

            // apply force at action point
            //GetComponent<Rigidbody>().AddForceAtPosition(upLift, actionPoint);
        }
	}
}
