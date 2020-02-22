using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Hareket_c1 : MonoBehaviour {
    private Hareket cc1_sayac;
    public GameObject silindir, silindir1,küp,canbar;
    float hızx = 0.032f;
    int hızy = 0;
    int düşman =1000;
    Vector3 hareket = new Vector3(0, 1, 0);
    int sayac = 8;
    void Start()
    {
        int x = Random.Range(3, 12);
        cc1_sayac = küp.GetComponent<Hareket>();
        silindir1.SetActive(false);
        Invoke("bekle", x);
    }
    void bekle()
    {
        silindir1.SetActive(true);
    }
    void Update()
    {
        move1();
    }
    void move1()
    {
        if(silindir1.transform.position == new Vector3(13.22f, -3.745986f, 0))
        {
            if (Vector3.Distance(silindir1.transform.position, silindir.transform.position) > 2.1f)
            {
                transform.position = silindir1.transform.position - (hareket * hızy);
                düşman += 3;
                cc1_sayac.can = cc1_sayac.can - 0.00012f;
                canbar.transform.localScale = new Vector3(cc1_sayac.can, 1, 1);
                //if (cc1_sayac.can >= 1f)
                //{
                //    SceneManager.LoadScene("ZamanDoldu");
                //}
                //else if (cc1_sayac.can <= 0f)
                //{
                //    SceneManager.LoadScene("GameOver");
                //}
            }
            else
            {
                transform.position = silindir1.transform.position - (hareket * hızy);
                int düşmanhasar = Random.Range(1, 70);
                düşman = düşman - düşmanhasar;
                if (düşman < 4)
                {
                    Sorgu_Makine();
                }
            }
        }
        else
        {
            if (Vector3.Distance(silindir1.transform.position, silindir.transform.position) > 2.1f)
            {
                transform.position = silindir1.transform.position - (hareket * hızx);
               
            }
            else
            {
                transform.position = silindir1.transform.position - (hareket * hızy);
                int düşmanhasar = Random.Range(1, 70);
                düşman = düşman - düşmanhasar;
                if (düşman < 4)
                {
                    Sorgu_Makine();
                }
            }
        }
    }
    void Sorgu_Makine()
    {
        if (sayac == 3)
        {
            sayac = 3;
        }
        else
        {
            sayac -= 1;
        }
        int x = Random.Range(3,sayac);
        düşman = 1000;
        silindir1.transform.position = new Vector2(13.22f, 10.11f);      
        silindir1.SetActive(false);      
        Invoke("bekle", x);
    }
}