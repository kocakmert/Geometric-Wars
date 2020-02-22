using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class newgame : MonoBehaviour {
    public Texture2D Home;
    public Texture2D Hover;
    void OnGUI()
    {
        GUI.skin.button.normal.background = Home;
        GUI.skin.button.hover.background = Hover;
        GUI.skin.button.active.background = Hover;
        if (GUI.Button(Funcion.Position(0.96f, 1f, 0.05f, 0.08f), ""))
        {
            int x = Random.Range(1, 4);
            if (x == 1)
            {
                SceneManager.LoadScene("GeometricWar");
            }
            else if (x == 2)
            {
                SceneManager.LoadScene("GeometricWar1");
            }
            else if(x==3)
            {
                SceneManager.LoadScene("GeometricWar3");
            }
        }
    }
  
}
