using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Button))]
public class Hat2SilindirOyuncu : MonoBehaviour {
    private Hareket cy_sayac; 
    public GameObject silindirx, silindiry, getir,canbar;
    public Button mybutton, küpsağ,silindirsağ,kapsülsağ,küpsol,silindirsol,kapsülsol,küporta,kapsülorta;
    int oyuncu = 1000;
    Vector3 hareket = new Vector3(0, 1, 0);
    float hız = 0.032f;
    int hızx = 0;
    void Start()
    {
        //int x = Random.Range(1, 5);
        silindirx.SetActive(false);
        cy_sayac = getir.GetComponent<Hareket>();
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
        kapsülorta.gameObject.SetActive(true);
    }
    void Update()
    {
        Move();
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
        kapsülorta.gameObject.SetActive(false);
        Invoke("bekle1", 1.3f);
    }
    public void Move()
    {
        silindirx.SetActive(true);
        mybutton.gameObject.SetActive(false);
        if(silindirx.transform.position == new Vector3(0.14f, 3.674001f, 0))
        {
            if (Vector3.Distance(silindirx.transform.position, silindiry.transform.position) > 2.1f)
            {
                transform.position = silindirx.transform.position + (hareket * hızx);
                oyuncu += 3;
                cy_sayac.can = cy_sayac.can + 0.00012f;
                canbar.transform.localScale = new Vector3(cy_sayac.can, 1, 1);
                //if (cy_sayac.can >= 1f)
                //{

                //    SceneManager.LoadScene("ZamanDoldu");
                //}
                //else if (cy_sayac.can <= 0f)
                //{
                //    SceneManager.LoadScene("GameOver");
                //}
            }
            else
            {
                transform.position = silindirx.transform.position + (hareket * hızx);
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
            if (Vector3.Distance(silindirx.transform.position, silindiry.transform.position) > 2.1f)
            {
                transform.position = silindirx.transform.position + (hareket * hız);
            }
            else
            {
                transform.position = silindirx.transform.position + (hareket * hızx);
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
        //int x = Random.Range(1, 2);
        silindirx.transform.position = new Vector2(0.14f, -8.87f);
        oyuncu = 1000;
        silindirx.SetActive(false);
        mybutton.gameObject.SetActive(false);
        Invoke("bekle", 1);
    }
}
