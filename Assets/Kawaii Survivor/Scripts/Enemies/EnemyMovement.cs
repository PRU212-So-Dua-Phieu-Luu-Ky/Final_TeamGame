using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header(" Elements ")]
    private Player player;

    [Header(" Settings ")]
    [SerializeField] private float moveSpeed = 1f;

    private void Start()
    {
    }

    public void StorePlayer(Player player)
    {
        this.player = player;
    }

    private void Update()
    {
        //if (player != null)
        //    FollowPlayer();
    }

    public void FollowPlayer()
    {
        Vector2 direction = (player.transform.position - transform.position).normalized;

        Vector2 targetPosition = (Vector2)transform.position + direction * moveSpeed * Time.deltaTime;

        transform.position = targetPosition;
    }
}