using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionBalance : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
      
        print(collision.gameObject.name + " : " + collision.gameObject.tag);

       
        if(collision.gameObject.CompareTag("Balance"))
        {
           
            GameObject[] plateformes = GameObject.FindGameObjectsWithTag("Plateforme");

          
            if (plateformes.Length > 0)
            {
            
                Destroy(plateformes[0]);
            }
        }
    }
}
