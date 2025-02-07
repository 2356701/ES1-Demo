using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExempleVariables : MonoBehaviour 
{
    [SerializeField] private float _tailleSaumon = 7.5f; // nombre décimaux et entiers mais surtout décimaux
   
   
   [SerializeField] private float _tailleSardine = 10f;

  [SerializeReference] private GameObject _saumon;
  [SerializeReference] private GameObject _sardine;

   int age = 10; // nombre entier uniquement
   
   
    // Start is called before the first frame update
    void Start()
    {
      // Debug.Log(tailleSaumon);
      
  
   
    }

    // Update is called once per frame
    void Update()
    { 
         // Debug.Log(tailleSaumon);
    
    }

   public void ComparerPoissons()
    {

       if(_tailleSaumon > _tailleSardine){
       
       
        Debug.Log("Ok");
        _sardine.SetActive(false);
      
      } 
       else {
            Debug.Log("Pas bon");
             _saumon.SetActive(false);
        }

    }
}
