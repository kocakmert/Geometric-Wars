using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Beraberlik : MonoBehaviour {

    public Font kimberley;
    public int fontsize;
    public Texture2D Normal;
    public Texture2D Hover;
    public int font = 80;
    void OnGUI()
    {
        Funcion.BoxToNull(kimberley, fontsize, Color.black);
        GUI.skin.button.normal.background = Normal;
        GUI.skin.button.hover.background = Hover;
        GUI.skin.button.active.background = Hover;
        GUI.skin.button.normal.textColor = Color.black;
        GUI.skin.button.hover.textColor = Color.yellow;
        GUI.skin.button.active.textColor = Color.yellow;
        GUI.skin.button.fontSize = 55;
        GUI.skin.button.font = kimberley;
        GUI.Box(Funcion.Position(1, 0.9f, 1, 0.2f), "BERABERE");
        if (GUI.Button(Funcion.Position(0.5f, 0.4f, 0.5f, 0.16f), "YENİ OYUN"))
        {
            int x = Random.Range(1, 6);
            if (x == 1)
            {
                SceneManager.LoadScene("GeometricWar");
            }
            else if (x == 2)
            {
                SceneManager.LoadScene("GeometricWar1");
            }
            else if (x == 3)
            {
                SceneManager.LoadScene("GeometricWar2");
            }
            else if (x == 4)
            {
                SceneManager.LoadScene("GeometricWar3");
            }
            else
            {
                SceneManager.LoadScene("GeometricWar4");
            }
        }
        if (GUI.Button(Funcion.Position(0.5f, 0.1f, 0.5f, 0.16f), "MENU"))
        {
            SceneManager.LoadScene("Menu");
        }
        if (GUI.Button(Funcion.Position(0.5f, -0.2f, 0.5f, 0.16f), "ÇIKIŞ"))
        {
            Application.Quit();
        }
       



    }
}
