namespace GoogleARCore.HelloAR
{
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Rendering;
    using GoogleARCore;
    using UnityEngine.UI;
    public class arrowrot : MonoBehaviour
    {
        public Camera FirstPersonCamera;
        public GameObject CameraTarget;
        private void LateUpdate()
        {  CameraTarget.transform.rotation = Frame.Pose.rotation;
          //    FirstPersonCamera.GetComponent<ArrowDirection>().targetRot = Frame.Pose.rotation;
        }
        }
 }
