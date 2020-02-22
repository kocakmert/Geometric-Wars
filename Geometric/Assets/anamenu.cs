using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class anamenu : MonoBehaviour {

    public Texture2D Homeana;
    public Texture2D Hoverana;
    void OnGUI()
    {
        GUI.skin.button.normal.background = Homeana;
        GUI.skin.button.hover.background = Hoverana;
        GUI.skin.button.active.background = Hoverana;
        if (GUI.Button(Funcion.Position(0.84f, 1f, 0.05f, 0.08f), ""))
        {
            SceneManager.LoadScene("Menu");
        }

    }

}
