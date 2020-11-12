using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("MovePanelOut", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MovePanelOut()
    {
        transform.localPosition = new Vector3(0, 1000, 0);
        transform.localScale = new Vector3(0.01f, 0.01f, 0);
    }

    public void MovePanelIn()
    {
        transform.localPosition = new Vector3(0, 0, 0);
        transform.localScale = new Vector3(1, 1, 1);
    }
}
