using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StudıoLoadarGuı : MonoBehaviour {
    public Font kimberley;
    public int fontsize;
    public Texture2D Normal;
    public float boxloading = 0.2f;
    public float speed = 0.003f;
    public string LastScene;
    void Update()
    {
        fontsize = Screen.width / 9;
        boxloading += speed;
        if (boxloading >= 1)
        {
            SceneManager.LoadScene(LastScene);
        }
    }
    void OnGUI()
    {
        Funcion.BoxToNull(kimberley, fontsize, Color.black);
        GUI.Box(Funcion.Position(1,0,1,0.3f), "Geko Games");
        GUI.skin.box.normal.background = Normal;
        GUI.Box(Funcion.Position(boxloading, -0.5f, boxloading, 0.08f), "");
    }
}
