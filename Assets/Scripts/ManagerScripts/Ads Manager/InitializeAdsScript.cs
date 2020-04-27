using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class InitializeAdsScript : MonoBehaviour
{

    string gameId = "3171681";
    bool testMode = true;

    private void Start()
    {
        Advertisement.Initialize(gameId, testMode);
    }
}
