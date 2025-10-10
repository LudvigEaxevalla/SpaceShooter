using Unity.VisualScripting;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public float enemySpeed = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);

        if (transform.position.y <= -5) {
            transform.position = new Vector3 (Random.Range(-8, 8), 5, transform.position.z);
        }

    }


}
