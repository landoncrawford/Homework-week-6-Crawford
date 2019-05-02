using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D birdRB;
    public float jumpSpeed = 5;
    public GameObject gameOverCanvas;
    public Text scoreText;

    public int currentScore;

    public AudioSource flipFlap;
    public AudioSource wolf;
    public AudioSource woahNo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space))
        {
            //Debug.Log("SPACE");
            birdRB.velocity = new Vector2(birdRB.velocity.x, jumpSpeed);
            flipFlap.Play();
        }
    }


    void OnCollisionEnter2D (Collision2D collision)
    {
        //Debug.Log("COLLISION");
        gameOverCanvas.SetActive(true);
        woahNo.Play();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        currentScore++;
        wolf.Play();
        scoreText.text = currentScore.ToString();
    }
}
