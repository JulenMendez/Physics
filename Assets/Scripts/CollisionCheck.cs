using UnityEngine;

public class CollisionCheck : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Empezando colision con " + collision.gameObject.name);
    }


    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Sigo colisionando con " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Saliendo de la colision con " + collision.gameObject.name);
    }
}
