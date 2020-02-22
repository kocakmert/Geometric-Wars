﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CapsuleHareket_C : MonoBehaviour {
    private Hareket cc2_sayac;
    public GameObject kapsül, kapsül1,küp,canbar;
    float hızx = 0.030f;
    int hızy = 0;
    int düşman = 1100;
    int sayac = 8;
    Vector3 hareket = new Vector3(0, 1, 0);
    void Start()
    {
        cc2_sayac = küp.GetComponent<Hareket>();
        kapsül1.SetActive(false);
        int x = Random.Range(3, 16);
        Invoke("bekle", x);
    }
    void bekle()
    {
        kapsül1.SetActive(true);
    }
    void Update()
    {
        move1();
    }
    void move1()
    {
        if (kapsül1.transform.position == new Vector3(16.99f, -3.990003f, 0))
        {
            if (Vector3.Distance(kapsül1.transform.position, kapsül.transform.position) > 2.1f)
            {
                transform.position = kapsül1.transform.position - (hareket * hızy);
                düşman += 4;
                cc2_sayac.can = cc2_sayac.can - 0.00015f;
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
                transform.position = kapsül1.transform.position - (hareket * hızy);
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
            if (Vector3.Distance(kapsül1.transform.position, kapsül.transform.position) > 2.1f)
            {
                transform.position = kapsül1.transform.position - (hareket * hızx);
            }
            else
            {
                transform.position = kapsül1.transform.position - (hareket * hızy);
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
        if (sayac == 3)
        {
            sayac = 3;
        }
        else
        {
            sayac -= 1;
            
        }
        int x = Random.Range(1, sayac);
        kapsül1.transform.position = new Vector2(16.99f, 10.11f);
        düşman = 1100;
        kapsül1.SetActive(false);    
        Invoke("bekle", x);
    }
}