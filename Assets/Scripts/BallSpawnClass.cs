using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BallSpawnClass : MonoBehaviour
{
    /*
     * Game starts; balls are thrown at player
     * Player will either catch the ball or deflect it? or get hit?
     * If caught, it is pocketed, once you have three, you can launch them back
     * at the NPC.  If the player hits the NPC, spawning is stalled for a few seconds.
     */

    public GameObject spawnTarget;

    public Transform[] waypoints;
    public int currentWaypoint;

    public float speed;

    private Vector3 offset;

    // Use this for initialization
    void Start ()
    {
        InvokeRepeating("Spawn", 4.0f, 2.0f);
        offset = new Vector3(0, 0, -1);
	}
	
	// Update is called once per frame
	void Update ()
    {
        //if i am at a waypoint, increase currentWaypoint so I move to the next
        if (transform.position == waypoints[currentWaypoint].position)
            currentWaypoint++;

        //if i am at the last waypoint, reset currentWaypoint so I go back to the first
        if (currentWaypoint >= waypoints.Length)
            currentWaypoint = 0;

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypoint].position, speed * Time.deltaTime);
    }

    void Spawn()
    {
        // Instantiate the spawn target at the spawner's position and rotation. 
        Instantiate(spawnTarget, transform.position + offset, transform.rotation);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("gameOver");
        }
    }
}
