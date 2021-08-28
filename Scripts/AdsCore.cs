using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class AdsCore : MonoBehaviour
{
    //[SerializeField]
    //bool testmode = true;
    private string gameID = "4253365";
    private string _banner = "Banner_Android";
    private string _video = "Interstitial_Android";

    void Start()
    {
        Advertisement.Initialize(gameID);

        #region banner
        StartCoroutine(ShowBannerWhenInitialized());
        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
        #endregion
    }

    public static void ShowAdsVideo(string placementID)
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show(placementID);
        }
        else
        {
            Debug.Log("Ad is not ready!");
        }
    }

    IEnumerator ShowBannerWhenInitialized()
    {
        while (!Advertisement.isInitialized)
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(_banner);
    }
}
