using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud1Script : MonoBehaviour
{
    float speed;
    float cloudPositionX;
    float cloudPositionY;
    // Start is called before the first frame update
    void Start()
    {
        cloudPositionX = Random.Range((float)-7.4, (float)7.4);
        cloudPositionY = Random.Range((float)-0.2, (float)4.2);
        speed = Random.Range((float)1, (float)3);
        transform.position = new Vector3(cloudPositionX, cloudPositionY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= 11.5)
        {
            transform.position = new Vector3((float)-11.5, cloudPositionY, 0);
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
