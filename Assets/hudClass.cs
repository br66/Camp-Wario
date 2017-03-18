using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class hudClass : MonoBehaviour
{
    public PlayerClass player;

    private Image health;
    private Image noticeOfFullStock;
    private Image ballStock;

    // all the necessary sprites until I know how Resources.Load works
    public Sprite oneLife, twoLife, threeLife;
    //public Sprite isNotFull, isFull;
    public Sprite noBalls, oneBall, twoBalls, threeBalls;

	// Use this for initialization
	void Start ()
    {
        health = transform.GetChild(0).GetChild(0).GetComponent<Image>();
        noticeOfFullStock = transform.GetChild(1).GetChild(0).GetComponent<Image>();
        ballStock = transform.GetChild(1).GetChild(1).GetComponent<Image>();

        health.sprite = threeLife;
        ballStock.sprite = noBalls;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (player.health == 1)
            health.sprite = oneLife;
        if (player.health == 2)
            health.sprite = twoLife;
        if (player.health == 3)
            health.sprite = threeLife;

        if (player.ballStock == 0)
            ballStock.sprite = noBalls;
        if (player.ballStock == 1)
            ballStock.sprite = oneBall;
        if (player.ballStock == 2)
            ballStock.sprite = twoBalls;
        if (player.ballStock == 3)
            ballStock.sprite = threeBalls;
    }
}
