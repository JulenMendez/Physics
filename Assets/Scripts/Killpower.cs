using UnityEngine;

public class Killpower : MonoBehaviour
{
    public float lifetime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, lifetime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Killable"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }



}
