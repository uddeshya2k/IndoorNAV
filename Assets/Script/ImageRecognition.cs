using ZXing;
using UnityEngine;
using GoogleARCore;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.InteropServices;


public class ImageRecognition : MonoBehaviour
{
    private bool searchingForMarker;
    public GameObject calibrationLocations;
    public GameObject person;



    // is used at start of application to set initial position
    public bool StartPosition(WebCamTexture wt)
    {
        bool succeeded = false;
        try
        {
            IBarcodeReader barcodeReader = new BarcodeReader();
            // decode the current frame
            var result = barcodeReader.Decode(wt.GetPixels32(), wt.width, wt.height);
            if (result != null)
            {
                Relocate(result.Text);
                succeeded = true;
            }
        }
        catch (Exception ex) { Debug.LogWarning(ex.Message); }
        return succeeded;
    }

    // move to person indicator to the new spot
    private void Relocate(string text)
    {
        text = text.Trim(); //remove spaces
                            //find the correct location scanned and move the person to its position
        foreach (Transform child in calibrationLocations.transform)
        {
            if (child.name.Equals(text))
            {
                person.transform.position = child.position;
                break;
            }
        }
        searchingForMarker = false;
    }
    void CaptureScreenAsync(Action<byte[], int, int> callback)
    {
        {
           
            
                byte[] imageByteArray = null;
                int width;
                int height;

                using (var imageBytes = Frame.CameraImage.AcquireCameraImageBytes())
                {
                    if (!imageBytes.IsAvailable)
                    {
                        callback(null, 0, 0);
                        return;
                    }

                    int bufferSize = imageBytes.YRowStride * imageBytes.Height;

                    imageByteArray = new byte[bufferSize];

                    Marshal.Copy(imageBytes.Y, imageByteArray, 0, bufferSize);

                    width = imageBytes.Width;
                    height = imageBytes.Height;
                }

                callback(imageByteArray, width, height);
            
        }
    }
}