using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameControl : MonoBehaviour
{
    [Header("TOP AYARLARI")]
    public GameObject topDestroyEffect;
    public AudioSource topYokOlmaSesi;

    [Header("ORTA KUTU AYARLARI")]
    public GameObject boxYokOlmaEfect;
    public AudioSource boxYokOlmaSesi;

    [Header("OYUNCU SAÐLIK AYARLARI")]
    public Image Oyuncu1HealtBar;
    float Oyuncu1Healt=100;
    public Image Oyuncu2HealtBar;
    float Oyuncu2Healt = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VoiceAndEffect(int kriter , GameObject objeTransform)
    {
       switch (kriter)
        {
            case 0:
                Instantiate(topDestroyEffect, objeTransform.gameObject.transform.position, objeTransform.gameObject.transform.rotation);
                topYokOlmaSesi.Play();
                break;
                
           case 1:
                Instantiate(boxYokOlmaEfect, objeTransform.gameObject.transform.position, objeTransform.gameObject.transform.rotation);
                boxYokOlmaSesi.Play();
                break;

        }
    }

    public void DarbeVur(int kriter, float darbeGucu)
    {
        switch (kriter)
        {
            case 0:
                Oyuncu1Healt -= darbeGucu;
                Oyuncu1HealtBar.fillAmount = Oyuncu1Healt / 100; //fill amount 0.10

                if (Oyuncu1Healt < 0)
                {
                    Debug.Log("Oyuncu 1 Yenildi.");
                }

                break;
            case 1:
                Oyuncu2Healt -= darbeGucu;
                Oyuncu2HealtBar.fillAmount = Oyuncu2Healt / 100; //fill amount 0.10

                if (Oyuncu2Healt < 0)
                {
                    Debug.Log("Oyuncu 2 Yenildi.");
                }
                break;

        }
    }
}
