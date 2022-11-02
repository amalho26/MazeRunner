using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public bool lookAtPlayer = false;
     public float smoothFactor = 0.5f;
    

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        Vector3 newPosition = player.transform.position + offset;
       
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);
        
        if(lookAtPlayer)
        {
            transform.LookAt(player);
        }
    }

    // Update is called once per frame
    void Update() {
    //     transform.position = player.transform.position + new Vector3(0, 1, -5);
    }
}
