
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float velocidad = 5f;
    [SerializeField] private float distanciaRayCast= 5f;
    [SerializeField] private float distanciaOverlap = 2f;
    [SerializeField] private int Daño = 10;
    private Rigidbody2D rb2d;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
     
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            InteractuarConObjeto();
        }

        if (Input.GetKey(KeyCode.E))
        {
            Atacar();
        }


        Caminar();
    }

    private void InteractuarConObjeto()
    {
         RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, distanciaRayCast);
      
         Debug.DrawRay(transform.position, Vector2.up * distanciaRayCast, Color.red);


        if (hit.collider.GetComponent<Iinteractuable>() != null)
         {

             Debug.Log("Interaccion" + hit.collider.name);

             hit.collider.GetComponent<Iinteractuable>().Acccion();

         }
         else
             Debug.Log("No estoy interactuando con objetos");
        
    }

    void Atacar()
    {
       Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position,distanciaOverlap);
       
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.GetComponent<IReciboDaño>() != null)
            {
                Debug.Log("Le Pegue" + hitCollider.name);
                hitCollider.GetComponent<IReciboDaño>().RecibirDaño(Daño);
            }

        }
           
    }

    void Caminar()
    {
        var Movimiento_X = Input.GetAxisRaw("Horizontal");
      
        rb2d.velocity = new Vector2(Movimiento_X * velocidad,0);

    }


}
