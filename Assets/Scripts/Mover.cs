using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float speed;

    //This code is executed on the very first frame this object is instantiated
    void Start ()
    {
        Rigidbody projectileRB = GetComponent<Rigidbody>();

        projectileRB.velocity = transform.forward * speed;
    }

}
