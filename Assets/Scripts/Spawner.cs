using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    public Transform[] Spawn_points = new Transform[10];
    public Random rndo = new Random();
    public GameObject testspawn;
    public GameObject player;
	// Use this for initialization
	void Start () {

        for (int i = 0; i < 9; i++)
        {
            Debug.Log("Ah Suh Dude" + i);
            GameObject fox = (GameObject)Instantiate(testspawn, Spawn_points[i].position, player.transform.rotation);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
