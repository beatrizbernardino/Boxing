using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleAnimation();
        
    }

    private void HandleAnimation() {
         if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            if(!animator.GetBool("isBoxing") && !animator.GetBool("isElbow") && !animator.GetBool("isJab") ){
                int i = Random.Range(1, 4);
                if(i == 1) {
                    animator.SetBool("isBoxing", true);
                } else if(i == 2) {
                    animator.SetBool("isElbow", true);
                } else if(i == 3) {
                    animator.SetBool("isJab", true);
                }
            }

        }
        else 
        {
            animator.SetBool("isBoxing", false);
       
            animator.SetBool("isElbow", false);
        
            animator.SetBool("isJab", false);
        }
      
   }

}
