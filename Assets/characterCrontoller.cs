using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterCrontoller : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetFloat("side", 0.0f);
            anim.SetInteger("Walk Side", 0);
            anim.SetInteger("speed", 1);
            anim.SetInteger("crouch", 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetInteger("speed", 0);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            anim.SetInteger("speed", 2);
            anim.SetFloat("side", 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            
            anim.SetInteger("crouch", 1);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetFloat("side", -1.0f);
            anim.SetInteger("Walk Side", -1);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetFloat("side", 1.0f);
            anim.SetInteger("Walk Side", 1);
        }
    }
}
