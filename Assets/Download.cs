using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Download : MonoBehaviour
{
  public void Onclick()
    {
        StartCoroutine(GetText());
    }

    IEnumerator GetText()
    {
        using (UnityWebRequest uwr = UnityWebRequestAssetBundle.GetAssetBundle("https://indoorar.blob.core.windows.net/assets-indoor-navigation/main "))
        {
            yield return uwr.SendWebRequest();

            if (uwr.isNetworkError || uwr.isHttpError)
            {
                Debug.Log(uwr.error);
            }
            else
            {
                // Get downloaded asset bundle
                AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(uwr);
                GameObject cube = bundle.LoadAsset<GameObject>("main");
                Instantiate(cube);
            }
        }
    }
}