using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Zamanlama : MonoBehaviour {
    public Text zaman;
    float time =90;
    public GameObject küp;
    public static int sayac;
    private Hareket cc_sayac;
    void Start()
    {
        cc_sayac = küp.GetComponent<Hareket>();
    }
    void Update()
    {
        if (cc_sayac.can > 0.99f)
        {
            sayac = sayac + 1;
            if (sayac > PlayerPrefs.GetInt("KAZANILAN SAVAŞLAR:", 0))
            {
                PlayerPrefs.SetInt("KAZANILAN SAVAŞLAR:", sayac);
                SceneManager.LoadScene("ZamanDoldu");
            }
        }
        if(cc_sayac.can < 0f)
        {
            SceneManager.LoadScene("GameOver");
        }
        if (time > 0)
        {
            
            time -= Time.deltaTime;
            zaman.text = "Time:" + time;
            if (time ==0.0000f)
            {
                zaman.text = "Time:" + 0;
            }
            

        }
        else 
        {
            if (cc_sayac.can > 0.5f)
            {
                
                sayac = sayac + 1;
                if (sayac > PlayerPrefs.GetInt("KAZANILAN SAVAŞLAR:", 0))
                {
                    PlayerPrefs.SetInt("KAZANILAN SAVAŞLAR:", sayac);
                    SceneManager.LoadScene("ZamanDoldu");
                }

            }
            
            else if (cc_sayac.can < 0.5)
            {
                SceneManager.LoadScene("GameOver");
            }
     

        }
        
    }
}
