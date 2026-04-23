using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject bullet;
    public int force;



    // Update is called once per frame
    void Update()
    {
        ShootBullet();
    }


    private void ShootBullet()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position = this.transform.localPosition;
            newBullet.GetComponent<Rigidbody>().AddForce(this.transform.forward * force);
        }
    }
}
