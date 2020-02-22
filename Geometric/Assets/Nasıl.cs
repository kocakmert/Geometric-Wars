using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Nasıl : MonoBehaviour {
   
    public Texture2D Normal;
    public Texture2D Hover;
    private void OnGUI()
    {
        
        GUI.skin.button.normal.background = Normal;
        GUI.skin.button.hover.background = Hover;
        GUI.skin.button.active.background = Hover;
        if (GUI.Button(Funcion.Position(0.9f, -0.5f, 0.1f, 0.1f), ""))
        {
            SceneManager.LoadScene("Menu");
        }
    }

}
