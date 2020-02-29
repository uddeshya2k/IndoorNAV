using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}