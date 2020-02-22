using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOverMenu : MonoBehaviour {   
    public Font kimberley;
    public int fontsize;
    public Texture2D Normal;
    public Texture2D Hover;
    public Text highscore;
    void Update()
    {
        highscore.text = "KAZANILAN SAVAŞLAR:" + PlayerPrefs.GetInt("KAZANILAN SAVAŞLAR:");      
    }
    void OnGUI()
    {       
        GUI.skin.button.normal.background = Normal;
        GUI.skin.button.hover.background = Hover;
        GUI.skin.button.active.background = Hover;
        GUI.skin.button.normal.textColor = new Color(219, 159, 0, 255);
        GUI.skin.button.hover.textColor = Color.black;
        GUI.skin.button.active.textColor = Color.cyan;
        GUI.skin.button.fontSize = 40;
        GUI.skin.button.font = kimberley;
        GUI.skin.box.font = kimberley;
        GUI.skin.box.fontSize = 60;
        GUI.skin.box.normal.textColor = new Color(219, 159, 0, 255);
        GUI.Box(Funcion.Position(1, 1f, 1, 0.2f), "YENİLGİ!!!.");
        if (GUI.Button(Funcion.Position(0.5f, -0.2f, 0.5f, 0.08f), "NEW GAME"))
        {
            int x = Random.Range(1,4);
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
        if (GUI.Button(Funcion.Position(0.5f, -0.4f, 0.5f, 0.08f), "MAIN MENU"))
        {
            SceneManager.LoadScene("Menu");
        }
        if (GUI.Button(Funcion.Position(0.5f, -0.6f, 0.5f, 0.08f), "QUIT"))
        {
            Application.Quit();
        }

    }
}
