using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class OffButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        StartCoroutine(GetRequest("http://192.168.0.102:4000"));
        GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
    }

    private void OnMouseUp()
    {
        StartCoroutine(GetRequest("http://192.168.0.102:4000"));
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
    }

    IEnumerator GetRequest(string uri)
    {
        UnityWebRequest uwr = UnityWebRequest.Get(uri);
        yield return uwr.SendWebRequest();

        if (uwr.isNetworkError)
        {
            Debug.Log("Error While Sending: " + uwr.error);
        }
        else
        {
            Debug.Log("Received: " + uwr.downloadHandler.text);
        }
    }
}
