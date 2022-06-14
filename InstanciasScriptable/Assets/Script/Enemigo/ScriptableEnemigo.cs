using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NombredelScriptable", menuName = "Enemy")]
public class ScriptableEnemigo : ScriptableObject
{
    [SerializeField] private string nombre;
    [SerializeField] private string daño;
    [SerializeField] private string vida;

    public string Nombre { get { return nombre; } }
    public string Daño { get { return daño; } }
    public string Vida { get { return vida; } }

    public void PrintData()
    {
        Debug.Log(nombre);
        Debug.Log(daño);
        Debug.Log(vida);
    }
}
