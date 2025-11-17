using System.Collections;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public int enemyCounter;
    private GameObject player;
    public float spawnTime = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(EnemySpawner());
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    IEnumerator EnemySpawner()
    {
        while (true)
        {
            if (enemyCounter < 3 && GameObject.Find("Player") != null)
            {
                Instantiate(enemy, new Vector3(Random.Range(-8, 8), 7, 0), Quaternion.identity);
                enemyCounter++;
                yield return new WaitForSeconds(spawnTime);
            }
            else yield return null;
        }
    }

}
