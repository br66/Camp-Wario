using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerClass : MonoBehaviour
{
    public Transform camera;
    public float rate = 1.0f;
    Vector3 eulerAngles;
    float answerfor;

    public int health = 3;
    public int ballStock = 0;

    public GameObject ball;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        eulerAngles = camera.eulerAngles;

        if (health < 0)
            health = 0;

        if (ballStock > 3)
            ballStock = 3;

        if (eulerAngles.z > 10.0f && eulerAngles.z < 90.0f)
            gameObject.transform.Translate(Vector3.left * camera.transform.rotation.z/rate);

        if (eulerAngles.z < 360.0f && eulerAngles.z > 270.0f)
            gameObject.transform.Translate(Vector3.left  * camera.transform.rotation.z/rate);

        if (transform.position.x > 3.5f)
            transform.position = new Vector3(3.5f, transform.position.y, transform.position.z);

        if (transform.position.x < -7)
            transform.position = new Vector3(-7.0f, transform.position.y, transform.position.z);

        // If the cardboard button is touched
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // If I have collected enough dodgeballs...
            if (ballStock == 3)
            {
                // Instantiate object using Main Camera's rotation
                Instantiate(ball, transform.position, transform.GetChild(0).rotation);
                // Change default speed, Enemy dodgeball and player dodgeball share same class.
                // Enemy dodgeball go in different direction than player ball, hence the speed change (to the opposite direction)
                ball.GetComponent<DodgeballClass>().speed = -10;
                // Reset how many dodgeball's collected
                ballStock = 0;
            }
        }

        if (health == 0)
        {
            SceneManager.LoadScene("gameOver");
        }
    }
}
