using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public AudioSource[] AudioClips = null;

    [HideInInspector] public float speed;
    [HideInInspector] public float speedX;
    [HideInInspector] public float speedY;
    [HideInInspector] public float angle;

    public float powerFactor = 0.34f;
    public float gravity = 0.6f;

    private int bounceCounter = 0;
    public GameObject explosionEffect;
    public GameObject particleEffect;

    

    // Start is called before the first frame update
    void Start()
    {
        float ballPower = GameObject.Find("CannonBall").GetComponent<CannonBallScript>().ballPower;
        if (ballPower == 0)
        {
            ballPower = 20;
        }
        speed = powerFactor*ballPower;
        float angle = GameObject.Find("CylinderPivot").GetComponent<CylinderPivotScript1>().angleCylinder;
        speedX = speed * Mathf.Cos(angle * Mathf.Deg2Rad);
        speedY = speed * Mathf.Sin(angle * Mathf.Deg2Rad);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedX * Time.deltaTime, speedY * Time.deltaTime, 0, relativeTo: Space.World);
        speedY -= gravity;
        
        if(transform.position.x <= -15 || transform.position.x >= 15)
        {
            GameObject.Find("FireButton").GetComponent<FireButtonScript>().onTrajectory = false;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            if (bounceCounter == 1)
            {
                bounceCounter = 0;
                Instantiate(explosionEffect, transform.position, transform.rotation);
                Destroy(gameObject);
            }
            else
            {
                AudioClips[0].Play();
                speedY *= (float)-0.9;
                bounceCounter += 1;
            }
        }

        if (collision.gameObject.tag == "Block")
        {
            AudioClips[0].Play();
            speedX *= -1;
        }

        if (collision.gameObject.tag == "Target")
        {
            GameObject.Find("CylinderPivot").GetComponent<CylinderPivotScript1>().SuccessTarget();
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Instantiate(particleEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(GameObject.Find("Target"));

        }


    }

}
