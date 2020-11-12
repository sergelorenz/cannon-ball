using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRightScript : MonoBehaviour
{
    [HideInInspector] public bool ArrowRightPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ArrowRightPressed == true)
        {

        }
        
    }

    public void ArrowRightPress()
    {
        ArrowRightPressed = true;
    }

    public void ArrowRightRelease()
    {
        ArrowRightPressed = false;
    }
}
