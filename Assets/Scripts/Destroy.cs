using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
   //場外に出たオブジェクトを消す処理を書く

   void OnTriggerEnter(Collider other) 
   {
      if (other.gameObject.tag == "Candy")
      {
        Destroy(other.gameObject);
      }
   }

}
