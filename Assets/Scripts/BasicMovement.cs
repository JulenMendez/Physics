using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    [SerializeField]
    private int velocity = 10;
    [SerializeField]
    private int rotationSpeed = 5;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 direction = Quaternion.AngleAxis(-90, Vector3.up) * this.transform.forward;
            this.transform.position += direction * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 direction = Quaternion.AngleAxis(90, Vector3.up) * this.transform.forward;
            this.transform.position += direction * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 direction = this.transform.forward;
            this.transform.position += direction * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 direction = -1 * this.transform.forward;
            this.transform.position += direction * velocity * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.rotation *= Quaternion.Euler(0, -rotationSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
        }
    }
}
