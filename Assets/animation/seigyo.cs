using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seigyo : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("attack");
        }
        //else
        {
            //animator.SetTriggerl("attack");
        }
        
        
    }
}
