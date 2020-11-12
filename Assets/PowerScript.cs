using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerScript : MonoBehaviour
{
    float amplitudeX = 0;    //(float)2.5;
    float frequencyX = 0;    //25;
    float amplitudeY = 0;    //float)1.5;
    float frequencyY = 0;    //45;
    Vector3 startingPos;
    Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = new Vector3((float)192.5, -147, 0);
        newPosition = new Vector3((float)192.5, -147, 0);
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.x = startingPos.x + (amplitudeX * Mathf.Sin(frequencyX * Time.time));
        newPosition.y = startingPos.y + (amplitudeY * Mathf.Sin(frequencyY * Time.time));
        transform.localPosition = newPosition;
    }

    public void ShakeSlider(float power)
    {
        if (power <= 50)
        {
            amplitudeX = 0;
            amplitudeY = 0;
            frequencyX = 0;
            frequencyY = 0;
        }
        else if (power > 50 && power <= 80)
        {
            amplitudeX = 0.05f*(power - 100) + 2.5f;
            frequencyX = 1.4f * (power - 100) + 75f;
            amplitudeY = 0;
            frequencyY = 0;
        }
        else
        {
            amplitudeX = 0.05f * (power - 100) + 2.5f;
            frequencyX = 1.4f * (power - 100) + 75f;
            amplitudeY = 0.075f*(power - 100) + 1.5f;
            frequencyY = 4.75f * (power - 100) + 100f;
        }

    }
}
