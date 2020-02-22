using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Hat2SilindirDüşman : MonoBehaviour {
    private Hareket cc_sayac;
    public GameObject silindiro, silindird, getir1,canbar;
    float hızx = 0.032f;
    int hızy = 0;
    int düşman = 1000;
    int sayac = 7;
    Vector3 hareket = new Vector3(0, 1, 0);
    void Start()
    {
        cc_sayac = getir1.GetComponent<Hareket>();
        silindird.SetActive(false);
        int y = Random.Range(3, 15);
        Invoke("bekle", y);
    }
    void bekle()
    {
        silindird.SetActive(true);
    }
    void Update()
    {
        move1();
    }
    void move1()
    {
        if(silindird.transform.position == new Vector3(0.14f, -3.745986f, 0))
        {
            if (Vector3.Distance(silindird.transform.position, silindiro.transform.position) > 2.1f)
            {
                transform.position = silindird.transform.position - (hareket * hızy);
                cc_sayac.can = cc_sayac.can - 0.00012f;
                düşman += 3;
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
                transform.position = silindird.transform.position - (hareket * hızy);
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
            if (Vector3.Distance(silindird.transform.position, silindiro.transform.position) > 2.1f)
            {
                transform.position = silindird.transform.position - (hareket * hızx);
            }
            else
            {
                transform.position = silindird.transform.position - (hareket * hızy);
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
        if (sayac == 2)
        {
            sayac = 2;
        }
        else
        {
            sayac -= 1;
        }
        int x = Random.Range(1, sayac);
        silindird.transform.position = new Vector2(0.14f, 10.11f);
        düşman = 1000;
        silindird.SetActive(false);       
        Invoke("bekle", x);
    }
}
