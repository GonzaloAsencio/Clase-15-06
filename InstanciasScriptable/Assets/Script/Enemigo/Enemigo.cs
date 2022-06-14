using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour,Iinteractuable,IReciboDaño
{
    public string Nombre;
    public int vida;
    public int daño;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
       
    }

    public void Acccion()
    {
        Debug.Log(Nombre + vida + daño);
    }

    public void RecibirDaño(int dmg)
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
