using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Button))]
public class CapsuleHareket : MonoBehaviour {
    private Hareket c1_sayac;
    public GameObject kapsül, kapsül1,getir1,canbar;
    public Button mybutton;
    public Button butonsilindir1;
    public Button butonkare1,ortaküp,ortakapsül,ortasilindir,solküp,solsilindir,solkapsül;
    int oyuncu = 1100;
    Vector3 hareket = new Vector3(0, 1, 0);
    float hız = 0.030f;
    int hızx = 0;
    void Start()
    {
        kapsül.SetActive(false);
        c1_sayac = getir1.GetComponent<Hareket>();
        mybutton.gameObject.SetActive(false);
        //int x = Random.Range(2, 4);
        Invoke("bekle", 3);
    }
    void bekle()
    {
        mybutton.gameObject.SetActive(true);
    }
    void bekle1()
    {
        butonkare1.gameObject.SetActive(true);
        butonsilindir1.gameObject.SetActive(true);
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
    public void tık()
    {
        butonkare1.gameObject.SetActive(false);
        butonsilindir1.gameObject.SetActive(false);
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
        kapsül.SetActive(true);
        mybutton.gameObject.SetActive(false);
        if (kapsül.transform.position == new Vector3(16.99f, 3.960013f, 0))
        {
            if (Vector3.Distance(kapsül.transform.position, kapsül1.transform.position) > 2.1f)
            {
                transform.position = kapsül.transform.position + (hareket * hızx);
                oyuncu += 4;
                c1_sayac.can = c1_sayac.can + 0.00015f;
                canbar.transform.localScale = new Vector3(c1_sayac.can, 1, 1);
                //if (c1_sayac.can >= 1f)
                //{

                //    SceneManager.LoadScene("ZamanDoldu");
                //}
                //else if (c1_sayac.can <= 0f)
                //{
                //    SceneManager.LoadScene("GameOver");
                //}
            }
            else
            {
                transform.position = kapsül.transform.position + (hareket * hızx);
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
            if (Vector3.Distance(kapsül.transform.position, kapsül1.transform.position) > 2.1f)
            {
                transform.position = kapsül.transform.position + (hareket * hız);
            }
            else
            {
                transform.position = kapsül.transform.position + (hareket * hızx);
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
        //int x = Random.Range(1, 3);
        kapsül.transform.position = new Vector2(16.99f, -8.94f);
        oyuncu =1100;
        kapsül.SetActive(false);
        mybutton.gameObject.SetActive(false);
        Invoke("bekle", 1);

    }
}