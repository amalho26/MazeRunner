using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public animationController anim;
    public GameObject player;
    public GameObject key;

    void OnTriggerEnter(Collider col){
        if(col.gameObject == player){
            anim.SetKey(true);
            Destroy(key);
        }
    }
}
