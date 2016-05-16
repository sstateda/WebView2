using UnityEngine;
using System.Collections;

public class myWebView : MonoBehaviour
{
    private string url = "http://google.co.jp";    // WebViewに表示するURL
    WebViewObject webViewObject;

    void Start()
    {
        webViewObject = GetComponent<WebViewObject>();
        webViewObject.Init();
        webViewObject.LoadURL(url);
        webViewObject.SetVisibility(true);
        webViewObject.SetMargins(0, 0, 0, 200);    // マージン(単位px) 左、上、右、下
    }
}