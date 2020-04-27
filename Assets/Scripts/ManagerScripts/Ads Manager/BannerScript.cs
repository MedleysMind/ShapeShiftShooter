using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Monetization;
using UnityEngine.Advertisements;

public class BannerScript : MonoBehaviour
{
   public string gameId = "3171681";
   public string placementId = "bannerPlacement";
    public bool testMode = true;

    void Start()
    {
        //Advertisement.Banner.SetPosition(BannerPosition.TOP_LEFT);
        //Advertisement.Banner.Show(placementId);
    }
}
