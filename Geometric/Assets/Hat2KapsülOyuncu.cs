using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Button))]
public class Hat2KapsülOyuncu : MonoBehaviour {
    private Hareket ccx_sayac;
    public GameObject kapsülx, kapsüly, getir,canbar;
    public Button mybutton,küpsağ,silindirsağ,kapsülsağ,küpsol,silindirsol,kapsülsol,küporta,silindirorta;
    int oyuncu = 1100;
    Vector3 hareket = new Vector3(0, 1, 0);
    float hız = 0.030f;
    int hızx = 0;
    void Start()
    {
        kapsülx.SetActive(false);
        ccx_sayac = getir.GetComponent<Hareket>();
        mybutton.gameObject.SetActive(false);
        Invoke("bekle", 3);       
    }
    void bekle()
    {
        mybutton.gameObject.SetActive(true);
    }
    void bekle1()
    {
        küpsağ.gameObject.SetActive(true);
        silindirsağ.gameObject.SetActive(true);
        kapsülsağ.gameObject.SetActive(true);
        küpsol.gameObject.SetActive(true);
        silindirsol.gameObject.SetActive(true);
        kapsülsol.gameObject.SetActive(true);
        küporta.gameObject.SetActive(true);
        silindirorta.gameObject.SetActive(true);
    }
    void Update()
    {
        Movex();
    }
    public void tık()
    {
        küpsağ.gameObject.SetActive(false);
        silindirsağ.gameObject.SetActive(false);
        kapsülsağ.gameObject.SetActive(false);
        küpsol.gameObject.SetActive(false);
        silindirsol.gameObject.SetActive(false);
        kapsülsol.gameObject.SetActive(false);
        küporta.gameObject.SetActive(false);
        silindirorta.gameObject.SetActive(false);
        Invoke("bekle1", 1.5f);
    }
    public void Movex()
    {
        kapsülx.SetActive(true);
        mybutton.gameObject.SetActive(false);
        if (kapsülx.transform.position == new Vector3(4.06f, 3.960013f, 0))
        {
            if (Vector3.Distance(kapsülx.transform.position, kapsüly.transform.position) > 2.1f)
            {
                transform.position = kapsülx.transform.position + (hareket * hızx);
                ccx_sayac.can = ccx_sayac.can + 0.00015f;
                oyuncu += 4;
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
                transform.position = kapsülx.transform.position + (hareket * hızx);
                int oyuncuhasar = Random.Range(1, 80);
                oyuncu = oyuncu - oyuncuhasar;
                if (oyuncu < 4)
                {
                    Sorgula_Oyuncu();
                }
            }
        }
        else
        {
            if (Vector3.Distance(kapsülx.transform.position, kapsüly.transform.position) > 2.1f)
            {
                transform.position = kapsülx.transform.position + (hareket * hız);
            }
            else
            {
                transform.position = kapsülx.transform.position + (hareket * hızx);
                int oyuncuhasar = Random.Range(1, 80);
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
       // int x = Random.Range(1, 3);
        kapsülx.transform.position = new Vector2(4.06f, -8.94f);
        oyuncu = 1100;
        kapsülx.SetActive(false);
        mybutton.gameObject.SetActive(false);
        Invoke("bekle",1);
    }
}
