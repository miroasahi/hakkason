using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kinokobehavir : MonoBehaviour
{
    private Animator anim = null;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //�t���[�����ƈړ�
        if (transform.position.x > -7.0f)
        {
            transform.Translate(-0.02f, 0, 0);
        }
        
        //�A�j���؂�ւ�
        if (transform.position.x < -7.0f)
        {
            anim.SetBool("New Bool",true);
        }
        else
        {
            anim.SetBool("New Bool",false);
        }

    }
}
