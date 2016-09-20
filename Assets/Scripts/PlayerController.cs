﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundry
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour {

    public float speed;
    public float tilt;
    public Boundry boundry;

    //executed once for each physics step
	void FixedUpdate ()
    {
        float movehorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movehorizontal, 0.0f, movevertical);
        Rigidbody playerRb = GetComponent<Rigidbody>();
        playerRb.velocity = movement*speed;

        playerRb.position = new Vector3
        (
            Mathf.Clamp(playerRb.position.x, boundry.xMin, boundry.xMax),
            0.0f,
            Mathf.Clamp(playerRb.position.z, boundry.zMin, boundry.zMax)
        );

        playerRb.rotation = Quaternion.Euler(0.0f, 0.0f, playerRb.velocity.x * -tilt);
    }
}
