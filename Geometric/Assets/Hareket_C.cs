using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Hareket_C : MonoBehaviour {
    private Hareket cc_sayac;
    public GameObject küp, küp1, canbar;
    float hızx = 0.035f;
    int hızy = 0;
    int düşman = 900;
    Vector3 hareket = new Vector3(0, 1, 0);
    public void Start()
    {      
        küp1.SetActive(false);
        cc_sayac = küp.GetComponent<Hareket>();
        int t = Random.Range(3, 17);
        Invoke("bekle", t);     
    }   
    void bekle()
    {
        küp1.SetActive(true);
    }
    void Update()
    {
        move1();
    }
    void move1()
    {
        if(küp1.transform.position == new Vector3(9.63f, -4.239981f, 0))
        {
            if (Vector3.Distance(küp1.transform.position, küp.transform.position) > 1.1f)
            {
                transform.position = küp1.transform.position - (hareket * hızy);
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
                transform.position = küp1.transform.position - (hareket * hızy);
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
            if (Vector3.Distance(küp1.transform.position, küp.transform.position) > 1.1f)
            {
                transform.position = küp1.transform.position - (hareket * hızx);
                
            }
            else
            {
                transform.position = küp1.transform.position - (hareket * hızy);
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
        int x = Random.Range(2, 10);
        küp1.transform.position = new Vector3(9.63f, 10.11f, 0);
        düşman = 900;
        küp1.SetActive(false);
        Invoke("bekle", x);
       
    }
}