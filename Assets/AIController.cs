using UnityEngine;

public class AIController : MonoBehaviour
{

    public float moveSpeed = 2f;
    public Transform player;

    void Update()
    {
        if (player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }
    }

}
