using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class sms : MonoBehaviour
{ string sender_mobile_numner = "8218446955";

    //recipient's mobile number array



    string sms_body = "Someone is at your Door";



    //for sending SMS to single recipient

    public void sendSingleSMS()
    {

        //Open the native SMS default app

        Application.OpenURL(string.Format("sms:" + sender_mobile_numner + "?body=" + sms_body));

    }


}

