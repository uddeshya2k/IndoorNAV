using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDirection : MonoBehaviour
{
    // Start is called before the first frame update
    public Quaternion targetRot;        // The rotation of the device camera from 
  //  Frame.Pose.rotation
    public GameObject arrow;            // The direction indicator on the person indicator
    //public GameObject sphere;
    void LateUpdate()
    {   float rotationSmoothingSpeed = 2.0f;
        Vector3 targetEulerAngles = targetRot.eulerAngles;
        float rotationToApplyAroundY = targetEulerAngles.y;
        float newCamRotAngleY = Mathf.LerpAngle(arrow.transform.eulerAngles.y, rotationToApplyAroundY, rotationSmoothingSpeed * Time.deltaTime);
        //float newCamRotAngleY1= Mathf.LerpAngle(sphere.transform.eulerAngles.y, rotationToApplyAroundY, rotationSmoothingSpeed * Time.deltaTime);
        Quaternion newCamRotYQuat = Quaternion.Euler(0, newCamRotAngleY, 0);
       // Quaternion newCamRotYQuat1 = Quaternion.Euler(0, newCamRotAngleY1, 0);
        arrow.transform.rotation = newCamRotYQuat;
        //sphere.transform.rotation = newCamRotYQuat1;
    }
}
