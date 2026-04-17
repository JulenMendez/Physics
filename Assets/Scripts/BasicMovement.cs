using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    private const int velocity = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += Vector3.left * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += Vector3.forward * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.back * velocity * Time.deltaTime;
        }
    }
}
