using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    public Transform[] Spawn_points = new Transform[10];
    public Random rndo = new Random();
    public GameObject testspawn;
    private int generatednumber;
	// Use this for initialization
	void Start () {
        generatednumber = Random.Range(1, 2);
        for (int i = 0; i < 9; i++)
        {
            Debug.Log("Ah Suh Dude" + i);
            GameObject fox = (GameObject)Instantiate(testspawn, Spawn_points[i].position, Spawn_points[i].rotation);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
