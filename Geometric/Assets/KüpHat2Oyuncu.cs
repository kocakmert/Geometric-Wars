using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Button))]
public class KüpHat2Oyuncu : MonoBehaviour {
    private Hareket ccx_sayac;
    public GameObject küpx, küpy, getir,canbar;
    public Button mybutton,küpsol,silindirsol,kapsülsol,silindirorta,kapsülorta,küpsağ,silindirsağ,kapsülsağ;
    int oyuncu = 900;
    Vector3 hareket = new Vector3(0, 1, 0);
    float hız = 0.035f;
    int hızx = 0;
    void Start()
    {
        küpx.SetActive(false);
        ccx_sayac = getir.GetComponent<Hareket>();
        mybutton.gameObject.SetActive(false);
        //int y = Random.Range(2, 5);
        Invoke("bekle", 3);
    }
    void bekle()
    {
        mybutton.gameObject.SetActive(true);
    }
    void bekle1()
    {
        küpsol.gameObject.SetActive(true);
        silindirsol.gameObject.SetActive(true);
        kapsülsol.gameObject.SetActive(true);
        silindirorta.gameObject.SetActive(true);
        kapsülorta.gameObject.SetActive(true);
        küpsağ.gameObject.SetActive(true);
        silindirsağ.gameObject.SetActive(true);
        kapsülsağ.gameObject.SetActive(true);
    }
    void Update()
    {
        Movex();
    }
    public void tık()
    {
        küpsol.gameObject.SetActive(false);
        silindirsol.gameObject.SetActive(false);
        kapsülsol.gameObject.SetActive(false);
        silindirorta.gameObject.SetActive(false);
        kapsülorta.gameObject.SetActive(false);
        küpsağ.gameObject.SetActive(false);
        silindirsağ.gameObject.SetActive(false);
        kapsülsağ.gameObject.SetActive(false);
        Invoke("bekle1",1f);
    }
    public void Movex()
    {
        küpx.SetActive(true);
        mybutton.gameObject.SetActive(false);
        if (küpx.transform.position == new Vector3(-3.92f, 4.092989f, 0))
        {
            if (Vector3.Distance(küpx.transform.position, küpy.transform.position) > 1.1f)
            {
                transform.position = küpx.transform.position + (hareket * hızx);
                oyuncu += 2;
                ccx_sayac.can = ccx_sayac.can + 0.0001f;
                canbar.transform.localScale = new Vector3(ccx_sayac.can, 1, 1);
                //if (ccx_sayac.can >= 1f)
                //{

                //    SceneManager.LoadScene("ZamanDoldu");
                //}
                //else if (ccx_sayac.can <= 0f)
                //{
                //    SceneManager.LoadScene("GameOver");
                //}
            }
            else
            {
                transform.position = küpx.transform.position + (hareket * hızx);
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
            if (Vector3.Distance(küpx.transform.position, küpy.transform.position) > 1.1f)
            {
                transform.position = küpx.transform.position + (hareket * hız);
               
            }
            else
            {
                transform.position = küpx.transform.position + (hareket * hızx);
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
        //int x = Random.Range(1, 5);
        küpx.transform.position = new Vector2(-3.92f, -8.332f);
        oyuncu = 1500;
        küpx.SetActive(false);
        mybutton.gameObject.SetActive(false);
        Invoke("bekle", 1);
    }
}