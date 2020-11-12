using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, (float)1.9);
        Invoke("BallLand", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BallLand()
    {
        GameObject.Find("FireButton").GetComponent<FireButtonScript>().onTrajectory = false;
    }

    
}
