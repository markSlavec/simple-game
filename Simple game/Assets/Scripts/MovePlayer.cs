using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovePlayer : MonoBehaviour
{
    public float speed = 5f, hSpeed = 10f;
    private Rigidbody _rb;
    public float _thrust = 500f;
     
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }


    /* private void Update()
     {
         //if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
         //    transform.Translate(new  Vector3(1, 0, 0) * Time.deltaTime * speed);
         //if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))  
         //    transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * -speed);

         float v = Input.GetAxis("Horizontal");
         transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime * v);


         float h = Input.GetAxis("Vertical");
         transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime * h); 
     } 
    */


    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * hSpeed * Time.fixedDeltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;

        _rb.velocity = transform.TransformDirection(new Vector3(h, _rb.velocity.y, v));

    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Block")
        {
            _rb.AddForce(new Vector3(1, 1, 0) * _thrust );
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collide");
    }

}
