using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        transform.LookAt(player);
        transform.Translate(Vector3.forward * 3 * Time.deltaTime);
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            Destroy(c.gameObject);
            Time.timeScale = 0;
        }
    }
}