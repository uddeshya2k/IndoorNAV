using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spherdis : MonoBehaviour
{   public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;
    public GameObject sphere4;
    public GameObject sphere5;
    public GameObject sphere6;
    public GameObject sphere7;
    public GameObject sphere8;
    public GameObject sphere9;
    public GameObject sphere10;
    public GameObject sphere11;
    public GameObject sphere12;
    public GameObject sphere13;
    public GameObject sphere14;
    public GameObject sphere15;
    public GameObject sphere16;
    public Dropdown dropdown;

    void Start()
    {
        sphere1.SetActive(false);
        sphere2.SetActive(false);
        sphere3.SetActive(false);
        sphere4.SetActive(false);
        sphere5.SetActive(false);
        sphere6.SetActive(false);
        sphere7.SetActive(false);
        sphere8.SetActive(false);
        sphere9.SetActive(false);
        sphere10.SetActive(false);
        sphere11.SetActive(false);
        sphere12.SetActive(false);
        sphere13.SetActive(false);
        sphere14.SetActive(false);
        sphere15.SetActive(false);
        sphere16.SetActive(false);
    }

    public void Spheredis()
    {
        if(dropdown.value == 1)
        {
            sphere1.SetActive(true);
        }
        if (dropdown.value == 2)
        {
            sphere2.SetActive(true);
        }
        if (dropdown.value == 3)
        {
            sphere3.SetActive(true);
        }
        if (dropdown.value == 4)
        {
            sphere4.SetActive(true);
        }
        if (dropdown.value == 5)
        {
            sphere5.SetActive(true);
        }
        if (dropdown.value == 6)
        {
            sphere6.SetActive(true);
        }
        if (dropdown.value == 7)
        {
            sphere7.SetActive(true);
        }
        if (dropdown.value == 8)
        {
            sphere8.SetActive(true);
        }
        if (dropdown.value == 9)
        {
            sphere9.SetActive(true);
        }
        if (dropdown.value == 10)
        {
            sphere10.SetActive(true);
        }
        if (dropdown.value == 11)
        {
            sphere11.SetActive(true);
        }
        if (dropdown.value == 12)
        {
            sphere12.SetActive(true);
        }
        if (dropdown.value == 13)
        {
            sphere13.SetActive(true);
        }
        if (dropdown.value == 14)
        {
            sphere14.SetActive(true);
        }
        if (dropdown.value == 15)
        {
            sphere15.SetActive(true);
        }
        if (dropdown.value == 16)
        {
            sphere16.SetActive(true);
        }
    }
}
