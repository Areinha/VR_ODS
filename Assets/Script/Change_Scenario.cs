﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scenario : MonoBehaviour
{



    public void ChangeScene(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
   

    
}
