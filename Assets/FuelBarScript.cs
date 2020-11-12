using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FuelBarScript : MonoBehaviour
{
    Transform bar;
    Vector3 scaleBar;

    [HideInInspector] public bool moving = false;
    float drainSpeed = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        bar = transform.Find("Bar");
        scaleBar = bar.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            scaleBar.x -= drainSpeed * Time.deltaTime;
            bar.localScale = scaleBar;
        }

        if (bar.localScale.x < 0)
        {
            moving = false;
            GameObject.Find("ArrowLeft").GetComponent<EventTrigger>().enabled = false;
            GameObject.Find("ArrowLeft").GetComponent<ArrowLeftScript>().ArrowLeftRelease();
            GameObject.Find("ArrowRight").GetComponent<EventTrigger>().enabled = false;
            GameObject.Find("ArrowRight").GetComponent<ArrowRightScript>().ArrowRightRelease();
            
            bar.localScale = new Vector3(0, 1, 1);
        }
    }

    public void FuelDrain()
    {
        moving = true;
    }

    public void FuelStop()
    {
        moving = false;
    }
}
