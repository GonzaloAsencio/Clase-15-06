using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NombredelScriptable", menuName = "Enemy")]
public class ScriptableEnemigo : ScriptableObject
{
    [SerializeField] private string nombre;
    [SerializeField] private string da�o;
    [SerializeField] private string vida;

    public string Nombre { get { return nombre; } }
    public string Da�o { get { return da�o; } }
    public string Vida { get { return vida; } }

    public void PrintData()
    {
        Debug.Log(nombre);
        Debug.Log(da�o);
        Debug.Log(vida);
    }
}
