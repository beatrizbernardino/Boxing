using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hombre : MonoBehaviour
{
    public int health = 200;
    public int previousHealth;
    public bool hit = false;
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
    // Debug.Log(collision.gameObject);
    // Debug.Log(this.gameObject.tag);
    
    if (collision.gameObject.tag == "BodyCollider" && hit)
    {   
        StartCoroutine(WaitPunch());
        health -= 20;
        Debug.Log($"vida: {health}");
        Texto.text=$"vida: {health}";
    }
    if (collision.gameObject.tag == "Gloves")
    {
        StartCoroutine(WaitDefense());
        hit = false;
        Debug.Log("Luva de pedreiro");
    }
    
 }

 IEnumerator WaitPunch() {
    yield return new WaitForSeconds(1);
 }

 IEnumerator WaitDefense() {
    yield return new WaitForSeconds(1);
    hit = true;
 }
}
