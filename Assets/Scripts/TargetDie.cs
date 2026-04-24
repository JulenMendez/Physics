using UnityEngine;

public class TargetDie : MonoBehaviour
{

    public int lifes;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Bullet") return;

        lifes--;
        if (lifes == 0)
        {
            Destroy(this.gameObject);
        }

        Destroy(collision.gameObject);
    }
}
