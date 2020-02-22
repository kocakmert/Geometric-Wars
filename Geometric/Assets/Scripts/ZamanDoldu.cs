using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ZamanDoldu : MonoBehaviour
{  
    public Font kimberley;
    public int fontsize;
    public Texture2D Normal;
    public Texture2D Hover;
    public Text highscore;   
    void Update()
    {
        
       highscore.text ="KAZANILAN SAVAŞLAR:" + PlayerPrefs.GetInt("KAZANILAN SAVAŞLAR:",Zamanlama.sayac);
    }
    void OnGUI()
    {
        
        GUI.skin.button.normal.background = Normal;
        GUI.skin.button.hover.background = Hover;
        GUI.skin.button.active.background = Hover;
        GUI.skin.button.normal.textColor = Color.black;
        GUI.skin.button.hover.textColor = Color.yellow;
        GUI.skin.button.active.textColor = Color.yellow;
        GUI.skin.button.fontSize = 40;
        GUI.skin.button.font = kimberley;
        GUI.Box(Funcion.Position(1, 1f, 1, 0.2f), "ZAFER!!!");

        if (GUI.Button(Funcion.Position(0.5f, 0.5f, 0.5f, 0.17f), "YENİ OYUN"))
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
        if (GUI.Button(Funcion.Position(0.5f, 0.12f, 0.5f, 0.17f), "ANA MENÜ"))
        {
            SceneManager.LoadScene("Menu");
        }
        if (GUI.Button(Funcion.Position(0.5f, -0.26f, 0.5f, 0.17f), "ÇIKIŞ"))
        {
            Application.Quit();
        }      
    }

}