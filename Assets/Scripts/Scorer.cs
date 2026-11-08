using UnityEngine;

public class Scorer : MonoBehaviour
{
    int collisions = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            collisions++;
            Debug.Log($"You've bumped into a thing this many times: {collisions}");
        }
    }
}
