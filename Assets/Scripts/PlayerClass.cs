using UnityEngine;
using System.Collections;

public class PlayerClass : MonoBehaviour
{
    public Transform camera;
    public float rate = 1.0f;
    public Vector3 eulerAngles;
    public float answerfor;
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        eulerAngles = camera.eulerAngles;

        if (eulerAngles.z > 20.0f && eulerAngles.z < 90.0f)
        {
            gameObject.transform.Translate(Vector3.left * camera.transform.rotation.z/rate);
        }

        if (eulerAngles.z < 350.0f && eulerAngles.z > 270.0f)
        {
            gameObject.transform.Translate(Vector3.left  * camera.transform.rotation.z/rate);
            
        }
        answerfor = camera.transform.rotation.z / rate;
    }
}
