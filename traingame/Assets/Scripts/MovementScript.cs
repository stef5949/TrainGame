using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float speed;
    public float maxSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody.velocity.x>maxSpeed|| rigidbody.velocity.x<-maxSpeed) {capSpeed();}

        if (Input.GetKey(KeyCode.D))
            {rigidbody.AddForce(new Vector2(speed, 0)*Time.deltaTime,ForceMode2D.Force);
            //gameObject.transform.Translate(new Vector3(speed, 0,0) * Time.deltaTime);
            }
        if (Input.GetKey(KeyCode.A))
            {rigidbody.AddForce(new Vector2(-speed, 0)* Time.deltaTime,ForceMode2D.Force);
            //gameObject.transform.Translate(new Vector3(-speed, 0,0) * Time.deltaTime);
            }

        print(rigidbody.velocity);
    }

    void capSpeed() {
        if (rigidbody.velocity.x > maxSpeed) { rigidbody.velocity = new Vector2(maxSpeed, 0); }
        else if (rigidbody.velocity.x < -maxSpeed) {rigidbody.velocity = new Vector2(-maxSpeed,0); }
        
        
    }
}
