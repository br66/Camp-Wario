using UnityEngine;
using System.Collections;

public class collisionActClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" && transform.parent.gameObject.GetComponent<PlayerClass>().health > 0)
        {
            transform.parent.gameObject.GetComponent<PlayerClass>().health -= 1;
        }
    }
}
