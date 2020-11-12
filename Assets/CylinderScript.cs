using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderScript : MonoBehaviour
{
    [HideInInspector] public bool cannonFired = false;
    Vector3 initialPos;
    float d = -2;
    float difference;
    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        if (cannonFired == false)
        {
        }
        else
        {
            transform.Translate(0,d*Time.deltaTime, 0);

            difference = initialPos.y - transform.localPosition.y;
            if (difference > 0.2)
            {
                d *= -1;
            }
            if (transform.localPosition.y > initialPos.y)
            {
                transform.localPosition = initialPos;
                cannonFired = false;
                d *= -1;
            }
        }

    }

    public void Recoil()
    {
        cannonFired = true;
    }
}