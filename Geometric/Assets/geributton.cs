using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class geributton : MonoBehaviour
{
    public Texture2D Home;
    public Texture2D Hover;
    void OnGUI()
    {
        GUI.skin.button.normal.background = Home;
        GUI.skin.button.hover.background = Hover;
        GUI.skin.button.active.background = Hover;
        if (GUI.Button(Funcion.Position(0.96f, 1f, 0.05f, 0.08f), ""))
        {
            SceneManager.LoadScene("Menu");
            
        }
    }
}
