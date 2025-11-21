using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public int playerSpeed = 5;
    public int playerHealth = 3;
    public GameObject projectile;
    public GameObject Health1;
    public GameObject Health2;
    public GameObject Health3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0, -4, 0);
        Health1 = GameObject.Find("Health");
        Health2 = GameObject.Find("Health (1)");
        Health3 = GameObject.Find("Health (2)");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }

        if (transform.position.x <= -10)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }


        else if (transform.position.x >= 10)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, this.transform.position, this.transform.rotation);
        }

    }

    public void TakeDamage()
    {
        playerHealth--;
        if (playerHealth <= 0)
        {
            Destroy(gameObject);
            Health1.GetComponent<UIScript>().HealthUpdate();
        }

        if (playerHealth == 1)
        {
            Health2.GetComponent<UIScript>().HealthUpdate();
        }

        if (playerHealth == 2)
        {
            Health3.GetComponent<UIScript>().HealthUpdate();
        }
    }
}
