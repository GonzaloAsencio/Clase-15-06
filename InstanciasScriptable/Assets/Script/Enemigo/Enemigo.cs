using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour,Iinteractuable,IReciboDa�o
{
    public string Nombre;
    public int vida;
    public int da�o;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
       
    }

    public void Acccion()
    {
        Debug.Log(Nombre + vida + da�o);
    }

    public void RecibirDa�o(int dmg)
    {
        vida -= dmg;
        if (vida <= 0)
        {
            anim.Play("Muerte");
          
        }
    }

    public void Muerte()
    {
        Destroy(this.gameObject);
    }
}
