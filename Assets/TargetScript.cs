using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public float speedX = 0;
    public float speedY = 0;
    public int level;
    public Vector3 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        level = LevelStaticDataScript.level;
        //randomized x-values


        //randomized y-values
        float height1to5 = Random.Range(-11, 25);          //for levels 1 - 10
        float height6to10 = Random.Range(40, 86);          //for levels 11 - 20
        float height11to15 = Random.Range(118, 141);          //for levels 21 - 31


        switch (level)
        {
            case 1:
                transform.localPosition = new Vector3(RandomXValue(-119), height1to5);
                break;
            case 2:
                transform.localPosition = new Vector3(RandomXValue(-39), height1to5);
                break;
            case 3:
                transform.localPosition = new Vector3(RandomXValue(41), height1to5);
                break;
            case 4:
                transform.localPosition = new Vector3(RandomXValue(121), height1to5);
                break;
            case 5:
                transform.localPosition = new Vector3(RandomXValue(201), height1to5);
                break;
            case 6:
                transform.localPosition = new Vector3(RandomXValue(-119), height6to10);
                break;
            case 7:
                transform.localPosition = new Vector3(RandomXValue(-39), height6to10);
                break;
            case 8:
                transform.localPosition = new Vector3(RandomXValue(41), height6to10);
                break;
            case 9:
                transform.localPosition = new Vector3(RandomXValue(121), height6to10);
                break;
            case 10:
                transform.localPosition = new Vector3(RandomXValue(201), height6to10);
                break;
            case 11:
                transform.localPosition = new Vector3(RandomXValue(-119), height11to15);
                break;
            case 12:
                transform.localPosition = new Vector3(RandomXValue(-39), height11to15);
                break;
            case 13:
                transform.localPosition = new Vector3(RandomXValue(41), height11to15);
                break;
            case 14:
                transform.localPosition = new Vector3(RandomXValue(121), height11to15);
                break;
            case 15:
                transform.localPosition = new Vector3(RandomXValue(201), height11to15);
                break;
            case 16:
                transform.localPosition = new Vector3(RandomXValue(-119), Random.Range(0, 120));
                speedY = 3;
                break;
            case 17:
                transform.localPosition = new Vector3(RandomXValue(-39), Random.Range(0, 120));
                speedY = 3;
                break;
            case 18:
                transform.localPosition = new Vector3(RandomXValue(41), Random.Range(0, 120));
                speedY = 3;
                break;
            case 19:
                transform.localPosition = new Vector3(RandomXValue(121), Random.Range(0, 120));
                speedY = 3;
                break;
            case 20:
                transform.localPosition = new Vector3(RandomXValue(201), Random.Range(0, 120));
                speedY = 3;
                break;
                

        }
        targetPosition = transform.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        if(level > 15 && level <= 20)
        {
            transform.Translate(0, speedY * Time.deltaTime, 0);
            if (transform.localPosition.y > 130)
            {
                targetPosition.y = 130;
                transform.localPosition = targetPosition;
                speedY *= -1;
            }
            if (transform.localPosition.y < -10)
            {
                targetPosition.y = -10;
                transform.localPosition = targetPosition;
                speedY *= -1;
            }

        }

    }

    float RandomXValue(float xMid)
    {
        return Random.Range(xMid - 25f, xMid + 25f);
    }

    
}
