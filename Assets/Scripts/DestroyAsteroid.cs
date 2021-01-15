using UnityEngine;

public class DestroyAsteroid : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    private GameController gameController;

    private void Start()
    {
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boundary")
        {
            return;
        }

        if (other.gameObject.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            gameController.GameOver();
        }
        else
        {
            Instantiate(explosion, transform.position, transform.rotation);
            gameController.updateScore();
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
