using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GazeClass : MonoBehaviour
{
    public Image timer;

    public float maxTime;
    public float time;

    public bool gazed = false;

	// Use this for initialization
	void Start ()
    {
        timer = transform.GetChild(0).GetComponent<Image>();

        time = maxTime;

        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    public void TimerOn()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            timer.fillAmount = time / maxTime;
        }
        else if (time <= 0)
        {
            if (transform.parent.gameObject.tag == "Enemy")
                gazed = true;
        }
    }

    public void TimerOff()
    {
        time = maxTime;
        timer.fillAmount = 1;
    }
}
