﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    GameObject g;
    public float Force;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) { rigidbody.AddForce(new Vector2(Force, 0)*Time.deltaTime);}
        if (Input.GetKey(KeyCode.A)) { rigidbody.AddForce(new Vector2(-Force, 0)* Time.deltaTime); }

    }
}
