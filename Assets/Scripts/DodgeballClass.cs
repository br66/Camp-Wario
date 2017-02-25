using UnityEngine;
using System.Collections;

public class DodgeballClass : MonoBehaviour
{

    // Use this for initialization
    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.GetComponent<Rigidbody>().AddForce(transform.forward * -10.0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }

        GetComponent<Rigidbody>().useGravity = true;
    }

    public void TestFunction()
    {
        Debug.Log("we made it");
    }
}
