using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;

    public float speed = 3f;

    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            player.position,
            speed * Time.deltaTime
        );
    }
}