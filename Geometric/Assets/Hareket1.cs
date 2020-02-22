using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Button))]
public class Hareket1 : MonoBehaviour {
    private Hareket c_sayac;
    public GameObject silindir, silindir1, getir, canbar;
    public Button mybutton;
    public Button kapsülsağ;
    public Button karesağ, ortaküp, ortasilindir, ortakapsül, solküp, solsilindir, solkapsül;
    int oyuncu = 1000;
    Vector3 hareket = new Vector3(0, 1, 0);
    float hız = 0.032f;
    int hızx = 0;
    void Start()
    {
        silindir.SetActive(false);
        mybutton.gameObject.SetActive(false);
        c_sayac = getir.GetComponent<Hareket>();
        Invoke("bekle", 3);
    }
    void bekle()
    {
        mybutton.gameObject.SetActive(true);
    }
    void Update()
    {
        Move();

    }
    void bekle1()
    {
        kapsülsağ.gameObject.SetActive(true);
        karesağ.gameObject.SetActive(true);
        ortaküp.gameObject.SetActive(true);
        ortakapsül.gameObject.SetActive(true);
        ortasilindir.gameObject.SetActive(true);
        solküp.gameObject.SetActive(true);
        solsilindir.gameObject.SetActive(true);
        solkapsül.gameObject.SetActive(true);
    }
    public void tik()
    {
        kapsülsağ.gameObject.SetActive(false);
        karesağ.gameObject.SetActive(false);
        ortakapsül.gameObject.SetActive(false);
        ortaküp.gameObject.SetActive(false);
        ortasilindir.gameObject.SetActive(false);
        solküp.gameObject.SetActive(false);
        solsilindir.gameObject.SetActive(false);
        solkapsül.gameObject.SetActive(false);
        Invoke("bekle1",1.5f);
    }
    public void Move()
    {
        silindir.SetActive(true);
        mybutton.gameObject.SetActive(false);
        if (silindir.transform.position == new Vector3(13.22f, 3.674001f, 0))
        {
            if (Vector3.Distance(silindir.transform.position, silindir1.transform.position) > 2.1f)
            {
                transform.position = silindir.transform.position + (hareket * hızx);
                oyuncu += 3;
                c_sayac.can = c_sayac.can + 0.00012f;
                canbar.transform.localScale = new Vector3(c_sayac.can, 1, 1);
                //if (c_sayac.can >= 1f)
                //{

                //    SceneManager.LoadScene("ZamanDoldu");
                //}
                //else if (c_sayac.can <= 0f)
                //{
                //    SceneManager.LoadScene("GameOver");
                //}
            }
            else
            {
                int oyuncuhasar = Random.Range(1, 70);
                oyuncu = oyuncu - oyuncuhasar;
                if (oyuncu < 4)
                {
                    Sorgula_Oyuncu();
                }
            }
        }
        else
        {
            mybutton.gameObject.SetActive(false);
            if (Vector3.Distance(silindir.transform.position, silindir1.transform.position) > 2.1f)
            {
                transform.position = silindir.transform.position + (hareket * hız);
            }
            else
            {
                transform.position = silindir.transform.position + (hareket * hızx);
                int oyuncuhasar = Random.Range(1, 70);
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
        silindir.transform.position = new Vector2(13.22f, -8.87f);
        oyuncu = 1000;
        silindir.SetActive(false);
        mybutton.gameObject.SetActive(false);
        Invoke("bekle", 1);
    }
}