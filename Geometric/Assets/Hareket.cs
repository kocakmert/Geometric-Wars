using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Button))]
public class Hareket : MonoBehaviour{
    public int skor;
    public GameObject küp, küp1, canbar;
    public Button mybutton;
    public Button silindirsağ;
    public Button kapsülsağ, ortaküp, ortasilindir, ortakapsül, solküp, solsilindir, solkapsül;
    int oyuncu = 900;
    Vector3 hareket = new Vector3(0, 1, 0);
    float hız = 0.035f;
    int hızx = 0;
    public float can;
    void Start()
    {
        küp.SetActive(false);
        mybutton.gameObject.SetActive(false);
        Invoke("bekle", 3);
    }
    void bekle()
    {
        mybutton.gameObject.SetActive(true);
    }
    void bekle1()
    {
        silindirsağ.gameObject.SetActive(true);
        kapsülsağ.gameObject.SetActive(true);
        ortaküp.gameObject.SetActive(true);
        ortakapsül.gameObject.SetActive(true);
        ortasilindir.gameObject.SetActive(true);
        solküp.gameObject.SetActive(true);
        solsilindir.gameObject.SetActive(true);
        solkapsül.gameObject.SetActive(true);
    }
    void Update()
    {
        Move();
    }
    public void tik()
    {
        silindirsağ.gameObject.SetActive(false);
        kapsülsağ.gameObject.SetActive(false);
        ortakapsül.gameObject.SetActive(false);
        ortaküp.gameObject.SetActive(false);
        ortasilindir.gameObject.SetActive(false);
        solküp.gameObject.SetActive(false);
        solsilindir.gameObject.SetActive(false);
        solkapsül.gameObject.SetActive(false);
        Invoke("bekle1",1f);

    }
    public void Move()
    {
        küp.SetActive(true);
        mybutton.gameObject.SetActive(false);
        if (küp.transform.position == new Vector3(9.63f, 4.092989f, 0))
        {
            if (Vector3.Distance(küp.transform.position, küp1.transform.position) > 1.1f)
            {
                transform.position = küp.transform.position + (hareket * hızx);
                oyuncu += 2;
                can = can + 0.0001f;
                canbar.transform.localScale = new Vector3(can, 1, 1);
                //if (can >= 1f)
                //{
                //    SceneManager.LoadScene("ZamanDoldu");
                //}
                //else if (can <= 0f)
                //{
                //    SceneManager.LoadScene("GameOver");
                //}
            }
            else
            {
                transform.position = küp.transform.position + (hareket * hızx);
                int oyuncuhasar = Random.Range(1, 60);
                oyuncu = oyuncu - oyuncuhasar;
                if (oyuncu < 4)
                {
                    Sorgula_Oyuncu();
                }
            }
        }
        else
        {

            if (Vector3.Distance(küp.transform.position, küp1.transform.position) > 1.1f)
            {
                transform.position = küp.transform.position + (hareket * hız);
            }
            else
            {
                transform.position = küp.transform.position + (hareket * hızx);
                int oyuncuhasar = Random.Range(1, 60);
                oyuncu = oyuncu - oyuncuhasar;
                if (oyuncu < 4)
                {
                    Sorgula_Oyuncu();
                }
            }
        }
    }
    void Sorgula_Oyuncu()
    {
        küp.transform.position = new Vector2(9.63f, -8.332f);
        oyuncu = 900;
        küp.SetActive(false);
        mybutton.gameObject.SetActive(false);
        Invoke("bekle", 1);
    }


}