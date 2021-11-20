using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class gamecontroll : MonoBehaviour
{
    private float health;
    public GameObject gameover;
    public Image healthbar;
    public GameObject[] engel;
    public GameObject olusacakengel;
    public Text kalanobje;
    private int kalan;
    public Button[] butonlarým;
    void Start()
    {
        health = 100;
        kalan = 30;
        kalanobje.text = kalan.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void kontrol()
    {
        if(kalan == 0)
        {
            foreach (var item in butonlarým)
            {
                item.interactable = false;
            }
        }
    }
    public void darbe(float darbeler)
    {
        health = health - darbeler;
        healthbar.fillAmount = health / 100;
        saglýk();
    }

    void saglýk()
    {
        if(health <= 0)
        {
            gameover.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void btn(int indisdeger)
    {
        kalan--;
        kalanobje.text = kalan.ToString();
        Instantiate(olusacakengel, engel[indisdeger].transform.position, Quaternion.identity);
        kontrol();
    }

    private void Instantiate()
    {
        throw new NotImplementedException();
    }
}
