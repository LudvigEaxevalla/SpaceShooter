using UnityEngine;

public class shieldScript : MonoBehaviour
{

    public int shieldHealth = 3;
    SpriteRenderer s_SpriteRenderer;
    Color s_newColor;

    float s_green;
    float s_blue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        s_SpriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShieldDamage()
    {
        s_green -= 100;
        s_blue -= 100;
        shieldHealth--;
        
        if (shieldHealth <= 0 )
        {
            Destroy(gameObject);
        }
    }
}
