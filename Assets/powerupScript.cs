using UnityEngine;

public class powerupScript : MonoBehaviour
{
    
    public powerupSpawner spawner;
    public float powerupSpeed = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawner = GameObject.Find("Powerup Spawner").GetComponent<powerupSpawner>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * powerupSpeed * Time.deltaTime);
        if (transform.position.y <= -5)
        {
            spawner.powerupCounter--;
            Destroy(gameObject);

        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            spawner.powerupCounter--;
            Destroy(gameObject);

        }
    }
}