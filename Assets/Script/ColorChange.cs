using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
    
{
    public Texture ODS7;
    public Texture ODS14;
    public Material Sky7;
    public void Red()
    {
        GetComponent<Renderer>().material.color = Color.white;
        GetComponent<Renderer>().material.mainTexture = ODS7;
        RenderSettings.skybox = default;
    }
 public void Blue()
    {
        GetComponent<Renderer>().material.color = Color.blue;
        GetComponent<Renderer>().material.mainTexture = ODS14;
        RenderSettings.skybox = Sky7;
    }
 public void Black()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }
}
