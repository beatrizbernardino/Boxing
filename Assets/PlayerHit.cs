using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHit : MonoBehaviour
{ 
    public Image healthbarEnemy;
    public Image headEnemy;
    public AudioSource painSound;
    float width;
    bool punch;
    public Text finalText;

    public Image healthbarPlayer;
    public Image headPlayer;    
    public GameObject chupacabra;
    private Animator animator;




    public Image playerImage;
    
  


    
    public int health = 200;
        
    // Start is called before the first frame update
    void Start()
    {
        width = 211;
        punch = true;
        animator = GameObject.Find("Macarena Dance").GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0) {

           finalText.text= "Você Ganhou!";
           finalText.gameObject.SetActive(true);


            healthbarPlayer.gameObject.SetActive(false);
            headPlayer.gameObject.SetActive(false);
            healthbarEnemy.gameObject.SetActive(false);
            headEnemy.gameObject.SetActive(false);  
            chupacabra.gameObject.SetActive(false);

            playerImage.gameObject.SetActive(true);
        }
    }

     void OnTriggerEnter (Collider collision)
    {
        if (collision.gameObject.tag == "Gloves")
        {
            if(punch) {
                animator.Play("Hit");
                animator.SetBool("isHit", false);
                health -= 20;
                painSound.Play();
                var theBarRectTransform =  healthbarEnemy.transform as RectTransform;
                width -= 21.5f;
                theBarRectTransform.sizeDelta = new Vector2 (width, theBarRectTransform.sizeDelta.y);
                headEnemy.transform.position  += new Vector3(0.013f, 0.0f, 0.0f);
                Debug.Log($"vida chupacabra: {health}");
                print("chupcabra corpinhpo");
                punch = false;


                StartCoroutine(WaitPunch());
                // StartCoroutine(WaitAnimation());
                // animator.SetBool("isHit", false);
            }



        }
        
    }

     IEnumerator WaitAnimation() {
        

       yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length+animator.GetCurrentAnimatorStateInfo(0).normalizedTime);
    }


    IEnumerator WaitPunch() {
        punch = true;


        yield return new WaitForSeconds(2);
    }
}
