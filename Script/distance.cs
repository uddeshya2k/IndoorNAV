using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class distance : MonoBehaviour
{
    public GameObject pos1;
   public  Transform pos2;
    public Dropdown dropdownfrom;
    public Dropdown dropdownt;
    public Transform position1;
    float distance1 = 0.1f;
    public TMP_Text stepsCount;
    /** public Transform position16;
     public Transform position17;
     public Transform position18;
     public Transform position19;
     public Transform position20;
     public Transform position21;
     public Transform position22;
     public Transform position23;
     public Transform position24;**/
    int step = 0;
    public GameObject g1;
    public GameObject g2;

    // Use this for initialization
    private void Start()
    {
        g1.SetActive(false);
        g2.SetActive(false);
    }

    public void OnP()
    {
        if (dropdownfrom.value == 5)
        {
            if (dropdownt.value == 7)
            {  
                pos2.transform.position = position1.transform.position;
                g1.SetActive(true);
                g2.SetActive(true);
            }
        }

    }        // Update is called once per frame
    void Update()
    {
        if (dropdownfrom.value == 5)
        {
            if (dropdownt.value == 7)
            {
                distance1 = (pos1.transform.position - pos2.transform.position).magnitude;
                step = (int)(distance1/1.31f);
                stepsCount.text = "No. of Steps:-"+(step.ToString());
            }
        }

    }
}