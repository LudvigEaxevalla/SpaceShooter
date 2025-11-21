using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;


public class UIScript : MonoBehaviour
{
    public int playerScore;
    public TMP_Text text;
    public Image h_Image;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = "Score: " + playerScore;
        h_Image = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreUpdate(int psScore)
    {
        playerScore += psScore;
        text.text = "Score: " + playerScore;
    }

    public void HealthUpdate()
    {
        h_Image.enabled = false;
    }


}
