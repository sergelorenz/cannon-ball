using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBackgroundScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor(float power)
    {
        //yRed = 0.0125x - 0.25
        //yGreen = -0.0125x + 1.25

        float redRatio = ((float)0.0125 * power) - (float)0.25;
        float greenRatio = ((float)-0.0125 * power) + (float)1.25;

        GetComponent<Image>().color = new Color(redRatio, greenRatio, 0);

    }
}
