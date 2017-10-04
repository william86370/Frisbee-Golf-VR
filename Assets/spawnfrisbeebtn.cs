using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnfrisbeebtn : MonoBehaviour {
    public Rigidbody ourfris;
    public Transform ourfrispos;
    // Use this for initialization
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "vive")
        {
            Rigidbody boxistance;
            boxistance = Instantiate(ourfris, ourfrispos.position, ourfrispos.rotation) as Rigidbody;
            
        }
    }
}
