using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ajan : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hedef;
    NavMeshAgent enemies;
    public string ajanturu;
    private int carpismasayisi;
    private float darbekuvveti;
    public GameObject gamekontrol;
    void Start()
    {
        enemies = GetComponent<NavMeshAgent>();
        enemies.SetDestination(hedef.transform.position);

        switch (ajanturu)
        {
            case "Siyah":
                carpismasayisi = 4;
                darbekuvveti = 50f;
                break;
            case "turuncu":
                carpismasayisi = 3;
                darbekuvveti = 3f; 
                break;
            case "Pembe":
                carpismasayisi = 2;
                darbekuvveti = 5f;
                break;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("engel"))
        {
            if (carpismasayisi != 1)
            {
                carpismasayisi++;
            }
            else if (carpismasayisi == 1)
            {
                Destroy(gameObject);
            }

        }
        if (other.gameObject.CompareTag("anahedef"))
        {
           gamekontrol.GetComponent<gamecontroll>().darbe(darbekuvveti);
            Destroy(gameObject);
        }
    }
   
}
