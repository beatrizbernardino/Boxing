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
    private Animator animator;
    public AudioSource punchSound;
    public Image healthbarEnemy;
    public Image healthbarPlayer;
    float width;


    // Start is called before the first frame update
    void Start()
    {
       width = 211;
         animator = GameObject.Find("Macarena Dance").GetComponent<Animator>();
   }

    // Update is called once per frame
    void Update()
    {
       if(health <= 0) {
          Texto.text = "Perdeu!!!"; 
           animator.SetBool("isLost", true);
           animator.SetBool("isBoxing", false);
           animator.SetBool("isJab", false);
           animator.SetBool("isElbow", false);
       }
    }

    void OnTriggerEnter (Collider collision)
 {
    // Debug.Log(collision.gameObject);
    // Debug.Log(this.gameObject.tag);
    
    if (collision.gameObject.tag == "BodyCollider" && hit)
    {   
        StartCoroutine(WaitPunch());
        punchSound.Play();
        health -= 20;
        Debug.Log($"vida: {health}");
        Texto.text=$"vida: {health}";
    

          var theBarRectTransform =  healthbarPlayer.transform as RectTransform;
          width -= 21.5f;
          theBarRectTransform.sizeDelta = new Vector2 (width, theBarRectTransform.sizeDelta.y);
          // DEAR BIAMAT OF FUTURE: Isso funciona mas voces precisam colocar na imagem do chupacabra
          // e nao a do retangulo! kisses x0x0 godibaie :) 
          theBarRectTransform.localPosition  += new Vector3(200.0f, 0.0f, 0.0f);
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
