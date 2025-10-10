using UnityEngine;

public class enemySpawner : MonoBehaviour
{

    public GameObject enemy;
    private int enemyCount = 500;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount--;
        if (enemyCount <= 0)
        {
            enemyCount = 500;
            Instantiate(enemy, new Vector3(Random.Range(-8, 8), 7, 0), Quaternion.identity);
        }
        


    }
}
