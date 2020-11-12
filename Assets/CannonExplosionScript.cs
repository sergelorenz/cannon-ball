using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonExplosionScript : MonoBehaviour
{
    public GameObject CannonExplosion;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        Instantiate(CannonExplosion, transform.position, transform.rotation);

    }
}
