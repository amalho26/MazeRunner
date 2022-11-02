using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    Vector3 angles;
    public animationController anim;
    public GameObject player;
    bool open = false;
    // Start is called before the first frame update
    void Start()
    {
        angles = transform.rotation.eulerAngles;
    }

    void Update()
    {
        if(open){
            if(angles.y <= 90){
                angles.y += 1f;
                transform.rotation = Quaternion.Euler(angles);
            }else{
                open = false;
            }
        }
    }

    
    void OnCollisionEnter(Collision col){
        if(col.gameObject == player){
            Debug.Log("Open");
            Debug.Log(anim.GetKey());
            if(anim.GetKey() == true){
               open = true;
                anim.SetKey(false);
            }
        }
    }

   

}


 
 
