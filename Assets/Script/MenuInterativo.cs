using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInterativo : MonoBehaviour
{
    public void Sair(string Scene)
    {
        SceneManager.LoadScene("PortaParaSair");
    }

    public void Voltar(string Scene)
    {
        SceneManager.LoadScene("Scene");
    }

    public void DoExitGame()
    {
        Application.Quit();
    }

}
