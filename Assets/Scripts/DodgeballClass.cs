using UnityEngine;
using System.Collections;

public class DodgeballClass : MonoBehaviour
{
    public PlayerClass player;
    public int speed;
    private GazeClass gazeTimer;

    // Use this for initialization
    void Start ()
    {
        Destroy(gameObject, 9.0f);
        player = GameObject.Find("Player").GetComponent<PlayerClass>();
        gazeTimer = transform.GetChild(0).GetComponent<GazeClass>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.GetComponent<Rigidbody>().AddForce(transform.forward * -speed);

        if (gazeTimer.gazed)
        {
            player.ballStock++;
            Destroy(gameObject);
        }
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
        //Debug.Log("we made it");
    }
}
