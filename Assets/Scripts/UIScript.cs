using UnityEngine;
using TMPro;
using Unity.VisualScripting;


public class UIScript : MonoBehaviour
{
    public int playerScore;
    public TMP_Text text;
    public TMP_Sprite healthSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = "Score: " + playerScore;
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


}
