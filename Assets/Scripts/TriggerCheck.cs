using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Empezando trigger con " + collider.gameObject.name);
    }


    private void OnTriggerStay(Collider collider)
    {
        Debug.Log("Sigo trigger con " + collider.gameObject.name);
    }

    private void OnTriggerExit(Collider collider)
    {
        Debug.Log("Saliendo del trigger con " + collider.gameObject.name);
    }
}
