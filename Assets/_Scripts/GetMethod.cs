using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GetMethod : MonoBehaviour
{
    public InputField outputArea;
    public InputField outputArea2;

    //private void Start()
    //{
    //    //outputArea = GameObject.Find("OutputArea").GetComponent<InputField>();
    //    //GameObject.Find("GetButton").GetComponent<Button>().onClick.AddListener(GetData);
    //}

    public void GetData() => StartCoroutine(GetData_Coroutine());
    IEnumerator GetData_Coroutine()
    {
        outputArea.text = "Loading";
        string url = "https://www.synicsw.com/api/items/2";
        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();

            if(request.isNetworkError || request.isHttpError)
            {
                outputArea.text = request.error;
            }
            else
            {
                outputArea.text = request.downloadHandler.text;
            }
        }
    }

    public void GetData2() => StartCoroutine(GetData2_Coroutine());
    IEnumerator GetData2_Coroutine()
    {
        outputArea2.text = "Loading";
        string url = "https://www.synicsw.com/api/items/1";
        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();

            if (request.isNetworkError || request.isHttpError)
            {
                outputArea2.text = request.error;
            }
            else
            {
                outputArea2.text = request.downloadHandler.text;
            }
        }
    }
}
