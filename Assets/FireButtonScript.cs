using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireButtonScript : MonoBehaviour
{
    [HideInInspector] public bool onTrajectory = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (onTrajectory)
        {
            GetComponent<Button>().interactable = false;
        }
        else
        {
            GetComponent<Button>().interactable = true;
        }

    }

    public void BallOnTrajectory()
    {
        onTrajectory = true;
    }
}
