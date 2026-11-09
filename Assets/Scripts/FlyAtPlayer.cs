using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerPosition;

    [SerializeField] float moveSpeed = 10.0f;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {        
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DestroyWhenReached();
        }
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, moveSpeed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        Destroy(gameObject);
    }
}
