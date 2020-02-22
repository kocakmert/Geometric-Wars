using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Hat2KapsülDüşman : MonoBehaviour {
    private Hareket cc2_sayac;
    public GameObject kapsüly, kapsülx, küp,canbar;
    float hızx = 0.030f;
    int hızy = 0;
    int düşman = 1100;
    Vector3 hareket = new Vector3(0, 1, 0);
    int sayac = 8;
    void Start()
    {
        cc2_sayac = küp.GetComponent<Hareket>();
        kapsüly.SetActive(false);
        int y = Random.Range(3, 16);
        Invoke("bekle", y);
    }
    void bekle()
    {
        kapsüly.SetActive(true);
    }
    void Update()
    {
        move1();
    }
    void move1()
    {
        if (kapsüly.transform.position == new Vector3(4.06f, -3.990003f, 0))
        {
            if (Vector3.Distance(kapsüly.transform.position, kapsülx.transform.position) > 2.1f)
            {
                transform.position = kapsüly.transform.position - (hareket * hızy);
                cc2_sayac.can = cc2_sayac.can - 0.00015f;
                düşman += 4;
                canbar.transform.localScale = new Vector3(cc2_sayac.can, 1, 1);
                //if (cc2_sayac.can >= 1f)
                //{
                //    SceneManager.LoadScene("ZamanDoldu");
                //}
                //else if (cc2_sayac.can <= 0f)
                //{
                //    SceneManager.LoadScene("GameOver");
                //}
            }
            else
            {
                transform.position = kapsüly.transform.position - (hareket * hızy);
                int düşmanhasar = Random.Range(1, 80);
                düşman = düşman - düşmanhasar;
                if (düşman < 4)
                {
                    Sorgu_Makine();
                }
            }
        }
        else
        {
            if (Vector3.Distance(kapsüly.transform.position, kapsülx.transform.position) > 2.1f)
            {
                transform.position = kapsüly.transform.position - (hareket * hızx);
            }
            else
            {
                transform.position = kapsüly.transform.position - (hareket * hızy);
                int düşmanhasar = Random.Range(1, 80);
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
        if (sayac==2)
        {
            sayac = 2;
        }
        else
        {
            sayac -= 1;
        }
        int x = Random.Range(3, sayac);
        kapsüly.transform.position = new Vector2(4.06f, 10.11f);
        düşman = 1100;
        kapsüly.SetActive(false);        
        Invoke("bekle", x);
    }
}
