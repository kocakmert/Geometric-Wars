using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcion : MonoBehaviour {
    public static Rect Position(float top, float left, float width, float height)
    {
        return new Rect(Screen.width * 0.5f - Screen.width * top * 0.5f, Screen.height * 0.5f - Screen.height * left * 0.5f, Screen.width * width, Screen.height * height);

    }
    public static void BoxToNull(Font font,int size, Color color)
    {
        GUI.skin.box.font = font;
        GUI.skin.box.fontSize = size ;
        GUI.skin.box.normal.background = null;
        GUI.skin.box.normal.textColor = color;
    }
    public static void BoxButton(Font font,Texture2D td, int size, Color color)
    {
        GUI.skin.box.font = font;
        GUI.skin.box.fontSize = size;
        GUI.skin.box.normal.background = null;
        GUI.skin.box.normal.textColor = color;
    }

}
