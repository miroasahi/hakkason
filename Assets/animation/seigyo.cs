using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seigyo : MonoBehaviour
{
    private Animator anim = null;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();//�A�j���[�^�[����R���|�[�l���g�擾

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))//atack anime�̍Đ�
        {
            Debug.Log("attack anime");//�m�F�p�̃��O�\��

            anim.SetBool("attack", true);

        }

        else
        {
            anim.SetBool("attack", false);
        }

        if (Input.GetKeyDown("a"))//attack�@anime2�̍Đ�
        {
            Debug.Log("attack anime2");

            anim.SetBool("attack2", true);
        }

        else
        {
            anim.SetBool("attack2", false);
        }

        if (Input.GetKeyDown("s"))//mettagiri anime�̍Đ�
        {
            Debug.Log("mettagiri anime");

            anim.SetBool("mettagiri", true);
        }

        else
        {
            anim.SetBool("mettagiri", false);
        }

        if (Input.GetKey("d"))//issen anime�̍Đ�
        {
            Debug.Log("issen anime");

            anim.SetBool("issen", true);
        }

        else
        {
            anim.SetBool("issen", false);
        }

    }

}
