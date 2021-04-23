using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
    
{
    public Texture IMG;
    public Texture INFO1;
    //public Texture INFO2;
   // public Material Sky7;
    public void Img()
    {
        
        GetComponent<Renderer>().material.mainTexture = IMG;
      //  RenderSettings.skybox = default;
    }
 public void Info1()
    {
        
        GetComponent<Renderer>().material.mainTexture = INFO1;
        //RenderSettings.skybox = Sky7;
    }
 /*public void Info2()
    {
        //GetComponent<Renderer>().material.color = Color.black;
        GetComponent<Renderer>().material.mainTexture = INFO2;
    }*/
}
