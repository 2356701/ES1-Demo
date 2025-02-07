using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

 public Vector3 myPos;
public Transform myPlay;

public void Update()
{
   transform.position = myPlay.position + myPos;
}
}
