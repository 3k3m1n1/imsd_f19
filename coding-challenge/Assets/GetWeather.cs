using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GetWeather : MonoBehaviour
{
    string key = "223f922df1b31fbd67b5c41e8b9e7776";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AskForWeather());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AskForWeather()
    {
        UnityWebRequest www = UnityWebRequest.Get("http://api.openweathermap.org/data/2.5/weather?zip=11692&mode=xml&APPID=" + key);
        Debug.Log("Request sent, pending response...");
        yield return www.SendWebRequest();

        if (!www.isNetworkError && !www.isHttpError)
            Debug.Log(www.downloadHandler.text);
        else
            Debug.Log(www.error + " " + www);


    }
}
