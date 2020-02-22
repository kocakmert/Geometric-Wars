using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HatBirD : MonoBehaviour {
    private Hareket cc_sayac;
    public GameObject küpy, küpx, getir1,canbar;
    float hızx = 0.035f;
    int hızy = 0;
    int düşman = 900;
    int sayac = 6;
    Vector3 hareket = new Vector3(0, 1, 0); 
    void Start()
    {
        cc_sayac = getir1.GetComponent<Hareket>();
        küpy.SetActive(false);
        int t = Random.Range(3,20);
        Invoke("bekle", t);
    }
    void bekle()
    {
        küpy.SetActive(true);
    }
    void Update()
    {
        move1();
    }
    void move1()
    {
        if(küpy.transform.position == new Vector3(-16.39f, -4.239981f, 0))
        {
            if (Vector3.Distance(küpy.transform.position, küpx.transform.position) > 1.1f)
            {
                transform.position = küpy.transform.position - (hareket * hızy);
                düşman += 2;
                cc_sayac.can = cc_sayac.can - 0.0001f;
                canbar.transform.localScale = new Vector3(cc_sayac.can, 1, 1);
                //if (cc_sayac.can >= 1f)
                //{
                //    SceneManager.LoadScene("ZamanDoldu");
                //}
                //else if (cc_sayac.can <= 0f)
                //{
                //    SceneManager.LoadScene("GameOver");
                //}
            }
            else
            {
                transform.position = küpy.transform.position - (hareket * hızy);
                int düşmanhasar = Random.Range(1, 60);
                düşman = düşman - düşmanhasar;
                if (düşman < 4)
                {
                    Sorgu_Makine();
                }
            }
        }
        else
        {
            if (Vector3.Distance(küpy.transform.position, küpx.transform.position) > 1.1f)
            {
                transform.position = küpy.transform.position - (hareket * hızx);
            }
            else
            {
                transform.position = küpy.transform.position - (hareket * hızy);
                int düşmanhasar = Random.Range(1, 60);
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
        if (sayac == 2)
        {
            sayac = 2;
        }
        else
        {
            sayac -= 1;
            
        }
        int x = Random.Range(1, sayac);
        küpy.transform.position = new Vector2(-16.39f, 10.11f);
        düşman = 900;
        küpy.SetActive(false);        
        Invoke("bekle", x);
    }
}
