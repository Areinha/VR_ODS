using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameAnalyticsSDK;

public class AnalyticLevelTrack : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (currentScene.name == "Energia_Eolica")
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "Energia_Eolica");
            Invoke("ChecarTempoEolica", 30);
        }

        else if (currentScene.name == "Hidroeletrica")
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "Hidroeletrica");
            Invoke("ChecarTempoHidroeletricaa", 30);            
        }

        else if (currentScene.name == "Moinho")
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "Moinho");
            Invoke("ChecarTempoMoinho", 30);
        }

        else if (currentScene.name == "Painel_Solar")
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "Painel_Solar");
            Invoke("ChecarTempoSolar", 30);            
        }

        else if (currentScene.name == "Usina_Nuclear")
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "Usina_Nuclear");
            Invoke("ChecarTempoNuclear", 30);            
        }

        else
        {
        }


        //Para inicializar o "Game Event Player Progression": GameAnalytics.NewProgressionEvent(GAProgression.GAProgressionStatus progressionStatus, string progression01, string progression02);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChecarTempoEolica()
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Energia_Eolica", 1);
    }

    void ChecarTempoHidroeletrica()
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Hidroeletrica", 1);
    }

    void ChecarTempoMoinho()
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Moinho", 1);
    }

    void ChecarTempoSolar()
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Painel_Solar", 1);
    }

    void ChecarTempoNuclear()
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Usina_Nuclear", 1);
    }

}

