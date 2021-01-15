using UnityEngine;

public class AsteroidRotator : MonoBehaviour
{
    public float tumble;
    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }
}
