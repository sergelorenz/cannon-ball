using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowScript : MonoBehaviour
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

        //shadow moving according to key pressed
        bool left = GameObject.Find("ArrowLeft").GetComponent<ArrowLeftScript>().ArrowLeftPressed;
        bool right = GameObject.Find("ArrowRight").GetComponent<ArrowRightScript>().ArrowRightPressed;

        if (left == true)
        {
            transform.Translate(Speed * Time.deltaTime * -1, 0, 0, relativeTo: Space.World);
        }
        else if (right == true)
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0, relativeTo: Space.World);
        }

        //shadow updating from rotation of cylinder
        float angle = GameObject.Find("CylinderPivot").GetComponent<CylinderPivotScript1>().angleCylinder;

        GetComponent<RectTransform>().sizeDelta = new Vector2(NewShadowLength(angle), (float)13.1);
    }

    float NewShadowLength(float angle)
    {
        float newLength = (float)1.61 * (float)32.8 * Mathf.Cos(angle * Mathf.Deg2Rad) + (float)0.4*(float)32.8*Mathf.Sin(angle*Mathf.Deg2Rad);
        return newLength;
    } 
}
