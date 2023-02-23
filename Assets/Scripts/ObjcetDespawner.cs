using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjcetDespawner : MonoBehaviour
{
   private void OnTriggerEnter(Collider col)
   {
    if(col.gameObject.tag == "Fruit"){
        Destroy(col.gameObject);
        //Debug.Log("Collide");
    }
    if(col.gameObject.tag == "Stone"){
        Destroy(col.gameObject);
    }
   }
}
