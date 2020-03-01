using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimap : MonoBehaviour
{
    public void changeSize()
    {
        GetComponent<RectTransform>().sizeDelta = new Vector2(180,230);
    }
}
