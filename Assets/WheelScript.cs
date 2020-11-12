using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelScript : MonoBehaviour
{
    private float speed = 1.5f;

    public float Speed { get => speed; set => speed = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool left = GameObject.Find("ArrowLeft").GetComponent<ArrowLeftScript>().ArrowLeftPressed;
        bool right = GameObject.Find("ArrowRight").GetComponent<ArrowRightScript>().ArrowRightPressed;

        if (left == true)
        {
            transform.Translate(Speed * Time.deltaTime * -1, 0, 0, relativeTo: Space.World);
            transform.Rotate(0, 0, Speed * Mathf.Rad2Deg * Time.deltaTime);
        }
        else if (right == true)
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0, relativeTo: Space.World);
            transform.Rotate(0, 0, -1 * Speed * Mathf.Rad2Deg * Time.deltaTime);
        }

    }
}
