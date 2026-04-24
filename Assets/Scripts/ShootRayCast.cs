using UnityEngine;

public class ShootRayCast : MonoBehaviour
{

    private MeshRenderer oldMr;
    private Color originalColor;

    public GameObject bullet;
    public int force;


    // Update is called once per frame
    void Update()
    {
        ShootRay();
        Shoot();
    }

    void ShootRay()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            MeshRenderer newMr = hit.collider.gameObject.GetComponent<MeshRenderer>();

            if (newMr == null) return;

            if (newMr == oldMr) return;

            if (oldMr != null) oldMr.material.color = originalColor;

            oldMr = newMr;
            originalColor = oldMr.material.color;
            oldMr.material.color = Color.green;
    }
        else
        {
            if (oldMr == null) return;
            
            oldMr.material.color = originalColor;
            oldMr = null;
            
        }
    }



    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position = this.transform.localPosition;
            newBullet.GetComponent<Rigidbody>().AddForce(this.transform.forward * force);
        }
    }
}
