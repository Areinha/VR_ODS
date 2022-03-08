using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameAnalyticsSDK;


public class AnalyticStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameAnalytics.Initialize();
        GameAnalytics.NewDesignEvent("IniciarJogo", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
