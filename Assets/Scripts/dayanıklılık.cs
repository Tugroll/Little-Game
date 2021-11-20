using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dayanıklılık : MonoBehaviour
{
    private int carpisma = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            if (carpisma != 3)
            {
                carpisma++;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
    


    void Update()
    {
        
    }
}
