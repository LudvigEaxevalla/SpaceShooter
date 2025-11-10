using Unity.VisualScripting;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UI;

public class enemyScript : MonoBehaviour
{
    public float enemySpeed = 3f;
    public enemySpawner spawner;
    public canvasScript Canvas;
    public Text scoreText;
    public int playerScore = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawner = GameObject.Find("Enemy Spawner").GetComponent<enemySpawner>();
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = playerScore.ToString();
        transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);

        if (transform.position.y <= -5) {
            transform.position = new Vector3 (Random.Range(-8, 8), 5, transform.position.z);
        }
   

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            other.transform.GetComponent<PlayerMovement>().TakeDamage();
            Debug.Log("Hit: " + other);
            spawner.enemyCounter--;
            Destroy(gameObject);

        }

        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
            spawner.enemyCounter--;
            playerScore++;
            Destroy(gameObject);
        }
    }


}
