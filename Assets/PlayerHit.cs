using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHit : MonoBehaviour
{ 
    
    public int health = 200;
    public Text Texto;
        
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
        if (collision.gameObject.tag == "Gloves")
        {

            health -= 20;
            Debug.Log($"vida chupacabra: {health}");
            Texto.text=$"vida chupacabra: {health}";
            print("chupcabra corpinhpo");
            StartCoroutine(WaitPunch());
        }
    }


    IEnumerator WaitPunch() {
        yield return new WaitForSeconds(1);
    }
}
