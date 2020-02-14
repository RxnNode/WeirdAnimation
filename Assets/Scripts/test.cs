using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    private void Start()
    {
        Screen.SetResolution(1080, 1080, false, 60);
    }
    //public Text text;


    //private AndroidJavaObject UnityActivity;
    //private AndroidJavaObject UnityInstance;

    //void Start()
    //{

    //    AndroidJavaClass _ajc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
    //    UnityActivity = _ajc.GetStatic<AndroidJavaObject>("currentActivity");

    //    AndroidJavaClass _ajcp = new AndroidJavaClass("com.antdm.unity.plugin");
    //    UnityInstance = _ajcp.CallStatic<AndroidJavaObject>("getInstance");
    //    UnityInstance.Call("setContext", UnityActivity);
    //}

    //void Update()
    //{
    //    long time = UnityInstance.Call<long>("getElapsedTime");
    //    text.GetComponent<Text>().text = "Time: " + time;
    //    Debug.Log("Time: " + time);
    //}


    //public void OnBtnClick()
    //{
    //    //showToast("there is a toast.", false);
    //    UnityInstance.Call("ShowToast", "There is another toast.", 0);

    //}

    //public void ShowToast(string msg, bool isLong)
    //{
    //    UnityActivity.Call("runOnUiThread", new AndroidJavaRunnable(() =>
    //    {   
    //        if(isLong == false)
    //        {
    //            UnityInstance.Call("ShowToast", msg, 0);
    //        }
    //        else
    //        {
    //            UnityInstance.Call("ShowToast", msg, 1);
    //        }
    //    }
    //    ));
    //}
}
