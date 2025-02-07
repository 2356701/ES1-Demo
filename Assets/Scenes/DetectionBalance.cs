using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionBalance : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Affiche le nom et le tag de l'objet en collision
        print(collision.gameObject.name + " : " + collision.gameObject.tag);

        // Vérifie si l'objet a le tag "Balance"
        if(collision.gameObject.CompareTag("Balance"))
        {
            // Cherche tous les objets ayant le tag "Plateforme" dans la scène
            GameObject[] plateformes = GameObject.FindGameObjectsWithTag("Plateforme");

            // Vérifie si des objets "Plateforme" existent
            if (plateformes.Length > 0)
            {
                // Détruire le premier objet "Plateforme" trouvé
                Destroy(plateformes[0]);
            }
        }
    }
}
