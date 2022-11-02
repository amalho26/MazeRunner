using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animationController : MonoBehaviour
{

    public float speed = 5f;

    Animator animator;
    bool hasKey = false;
   
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update ()
    {
        float horizontal = Input.GetAxis ("Horizontal");
        float vertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3(horizontal, 0f, vertical);

       if(movement.magnitude > 0)
       {
        movement.Normalize();
        movement *= speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
       }

        float velocityZ = Vector3.Dot(movement.normalized, transform.forward);
        float velocityX = Vector3.Dot(movement.normalized, transform.right);
        animator.SetFloat("VelocityZ", velocityZ, 0.1f, Time.deltaTime);
        animator.SetFloat("VelocityX", velocityX, 0.1f, Time.deltaTime);

        
    }

    public bool GetKey(){
        return hasKey;
    }
    public void SetKey(bool key){
        hasKey = key;
    }
    
}
