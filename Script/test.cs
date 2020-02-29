using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public Dropdown dropdown;
    public Transform position0;
    public Transform position1;
    public Transform position2;
    public Transform position3;
    public Transform position4;
    public Transform position5;
    public Transform position6;
    public Transform position7;
    public Transform position8;
    public Transform position9;
    public Transform position10;
    public Transform position11;
    public Transform position12;
    public Transform position13;
    public Transform position14;
    public Transform position15;
   /** public Transform position16;
    public Transform position17;
    public Transform position18;
    public Transform position19;
    public Transform position20;
    public Transform position21;
    public Transform position22;
    public Transform position23;
    public Transform position24;**/

    public Transform myObject;
    // Use this for initialization


   public void OnC()
    {
        
        if (dropdown.value == 1)
        {
           myObject.transform.position = position0.transform.position;
           myObject.transform.rotation = position0.transform.rotation;

        }
        if (dropdown.value == 2)
        {
            myObject.transform.position = position1.transform.position;
            myObject.transform.rotation = position1.transform.rotation;
        }
        if (dropdown.value == 3)
        {
             myObject.transform.position = position2.transform.position;
            myObject.transform.rotation = position2.transform.rotation;
        }
        if (dropdown.value == 4)
        {
            myObject.transform.position = position3.transform.position;
            myObject.transform.rotation = position3.transform.rotation;
        }
        if (dropdown.value == 5)
        {
            myObject.transform.position = position4.transform.position;
            myObject.transform.rotation = position4.transform.rotation;
        }
        if (dropdown.value == 6)
        {
            myObject.transform.position = position5.transform.position;
            myObject.transform.rotation = position5.transform.rotation;
        }
        if (dropdown.value == 7)
        {
            myObject.transform.position = position6.transform.position;
            myObject.transform.rotation = position6.transform.rotation;
        }
        if (dropdown.value == 8)
        {
            myObject.transform.position = position7.transform.position;
            myObject.transform.rotation = position7.transform.rotation;
        }
        if (dropdown.value == 9)
        {
            myObject.transform.position = position8.transform.position;
            myObject.transform.rotation = position8.transform.rotation;
        }
        if (dropdown.value == 10)
        {
            myObject.transform.position = position9.transform.position;
            myObject.transform.rotation = position9.transform.rotation;
        }
        if (dropdown.value == 11)
        {
            myObject.transform.position = position10.transform.position;
            myObject.transform.rotation = position10.transform.rotation;
        }
        if (dropdown.value == 12)
        {
            myObject.transform.position = position11.transform.position;
            myObject.transform.rotation = position11.transform.rotation;
        }
        if (dropdown.value == 13)
        {
            myObject.transform.position = position12.transform.position;
            myObject.transform.rotation = position12.transform.rotation;
        }
        if (dropdown.value == 14)
        {
            myObject.transform.position = position13.transform.position;
            myObject.transform.rotation = position13.transform.rotation;
        }
        if (dropdown.value == 15)
        {
            myObject.transform.position = position14.transform.position;
            myObject.transform.rotation = position14.transform.rotation;
        }
        /** if (dropdown.value == 16)
         {
             myObject.transform.position = position15.transform.position;
         
         }
         if (dropdown.value == 17)
         {
             myObject.transform.position = position16.transform.position;
         
         }
         if (dropdown.value == 18)
         {
             myObject.transform.position = position16.transform.position;
         }
         if (dropdown.value == 19)
         {
             myObject.transform.position = position17.transform.position;
         }
         if (dropdown.value == 20)
         {
             myObject.transform.position = position18.transform.position;
         }
         if (dropdown.value == 21)
         {
             myObject.transform.position = position19.transform.position;
         }
         if (dropdown.value == 22)
         {
             myObject.transform.position = position20.transform.position;
         }
         if (dropdown.value == 23)
         {
             myObject.transform.position = position21.transform.position;
         }
         if (dropdown.value == 24 )
         {
             myObject.transform.position = position22.transform.position;
         }
         if (dropdown.value == 25)
         {
             myObject.transform.position = position23.transform.position;
         }
         if (dropdown.value == 26)
         {
             myObject.transform.position = position24.transform.position;
         }

     **/
    }
}
