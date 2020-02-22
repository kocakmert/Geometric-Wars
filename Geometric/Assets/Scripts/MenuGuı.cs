using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuGuı :  MonoBehaviour {
   
     public Font kimberley;
     public int fontsize;
     public Texture2D Normal;
     public Texture2D Hover;
     public int font = 80;
     public Text highscore;
     
     void Update()
     {
        highscore.text = "KAZANILAN SAVAŞLAR:" + PlayerPrefs.GetInt("KAZANILAN SAVAŞLAR:",Zamanlama.sayac);
     }
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
        GUI.Box(Funcion.Position(1, 1.02f, 1, 0.2f), "GEOMETRIC WARS");
        if (GUI.Button(Funcion.Position(0.5f, 0.57f, 0.5f, 0.2f), "YENİ OYUN"))
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
            else if (x == 3)
            {
                SceneManager.LoadScene("GeometricWar3");
            }
        }
        if (GUI.Button(Funcion.Position(0.5f, 0.23f, 0.5f, 0.2f), "NASIL OYNANIR"))
        {
            SceneManager.LoadScene("nasiloynanir");
        }
        if (GUI.Button(Funcion.Position(0.5f, -0.11f, 0.5f, 0.2f), "ÇIKIŞ"))
        {
            Application.Quit();
        }
        
    }
   
}
