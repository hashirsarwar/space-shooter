using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        direction = transform.forward;
    }

    void Update()
    {
        rb.velocity = direction * speed;
    }
}
