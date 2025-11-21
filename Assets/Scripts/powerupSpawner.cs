using System.Collections;
using UnityEngine;

public class powerupSpawner : MonoBehaviour
{

    public GameObject PowerUp;
    public int powerupCounter;
    private GameObject player;
    public float spawnTime = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(PowerupSpawner());
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    IEnumerator PowerupSpawner()
    {
        while (true)
        {
            if (powerupCounter < 2 && GameObject.Find("Player") != null)
            {
                Instantiate(PowerUp, new Vector3(Random.Range(-8, 8), 7, 0), Quaternion.identity);
                powerupCounter++;
                yield return new WaitForSeconds(spawnTime);
            }
            else yield return null;
        }
    }

}
