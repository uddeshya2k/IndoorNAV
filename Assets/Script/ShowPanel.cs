using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanel : MonoBehaviour
{
    //public GameObject trigger;
    public GameObject g1;
   public void OnTriggerEnter(Collider other)
    {
        g1.SetActive(true);
    }
  // public void OnTriggerExit(Collider other)
  //  {
        //g1.SetActive(false);
  //  }

}
