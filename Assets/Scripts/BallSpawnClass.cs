using UnityEngine;
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

    // Use this for initialization
    void Start ()
    {
        InvokeRepeating("Spawn", 4.0f, 2.0f);
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
        Instantiate(spawnTarget, transform.position, transform.rotation);
    }
}
