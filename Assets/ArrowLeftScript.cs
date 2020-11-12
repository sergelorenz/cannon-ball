using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowLeftScript : MonoBehaviour
{
    [HideInInspector] public bool ArrowLeftPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ArrowLeftPress()
    {
        ArrowLeftPressed = true;
    }

    public void ArrowLeftRelease()
    {
        ArrowLeftPressed = false;
    }
}
