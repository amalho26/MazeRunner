using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 100f;
    Animator animator;


     void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        Vector3 movement = new Vector3(rotation, 0f, translation);
       if(movement.magnitude > 0)
       {
        movement.Normalize();
        movement *= speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
       }
        float velocityZ = Vector3.Dot(movement.normalized, transform.forward);
        
        animator.SetFloat("VelocityZ", velocityZ, 0.1f, Time.deltaTime);
       
       
       transform.Translate(0,0,translation);
       transform.Rotate(0,rotation,0);
    }
}
