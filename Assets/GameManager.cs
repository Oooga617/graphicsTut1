using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //UI Text
    public TextMeshProUGUI conditionText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        conditionText.text = "";
    }

    public void displayWin()
    {
        conditionText.text = "YOU DID IT!!! :D";
    }

    public void displayLose()
    {
        conditionText.text = "YOU TOUCHED THE MIDDLE CUBE >:(";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
