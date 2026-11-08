using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRotation = 0.0f;
    [SerializeField] float yRotation = 1.0f;
    [SerializeField] float zRotation = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotation, yRotation, zRotation);
    }
}
