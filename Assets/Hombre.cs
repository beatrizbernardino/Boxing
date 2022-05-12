using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hombre : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider collision)
 {
    
     if (collision.gameObject.tag == "ChupacabraArm")
    {
        Debug.Log(collision.gameObject.tag);
    }
    if (collision.gameObject.tag == "Gloves")
    {
        Debug.Log("Luva de pedreiro");
    }
    
 }
}
