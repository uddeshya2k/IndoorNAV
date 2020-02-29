using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switchscene : MonoBehaviour
{
   public void menu()
    {
        SceneManager.LoadScene("part1");
    }
    public void exit()
    {
        Application.Quit();
        Debug.Log("EXIT button pressed");
    }
}
