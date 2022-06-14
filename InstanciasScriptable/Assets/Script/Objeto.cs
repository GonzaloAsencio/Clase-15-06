using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour,Iinteractuable
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void Acccion()
    {
        anim.Play("Start");  
    }

}
