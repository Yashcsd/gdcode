using UnityEngine;

public class MoveWASDA : MonoBehaviour
{
    public float speed = 5f;
    public float jump = 5f;

    Rigidbody rb;
    bool ground = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(x * speed * Time.deltaTime, 0, z * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && ground)
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            ground = false;
        }
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Ground")
        {
            ground = true;
        }
    }

    void OnTriggerEnter(Collider c)
{
    if (c.CompareTag("Coin"))
    {
        FindObjectOfType<Score>().Add();

        Destroy(c.gameObject);
    }
}
}