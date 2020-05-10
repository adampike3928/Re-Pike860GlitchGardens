using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LivesDisplay : MonoBehaviour
{
    [SerializeField] float fltBaseLives = 3;
    [SerializeField] int intDamage = 1;

    float intLives;
    Text livesText;
    // Start is called before the first frame update
    void Start()
    {
        intLives = fltBaseLives - PlayerPrefsController.GetDifficulty();
        livesText = GetComponent<Text>();
        UpdateDisplay();
        Debug.Log("Difficulty setting currently is " + PlayerPrefsController.GetDifficulty());
    }
    private void UpdateDisplay()
    {
        livesText.text = intLives.ToString();
    }

    public void TakeLife()
    {
        intLives -= intDamage;
        UpdateDisplay();
        if (intLives <= 0)
        {
            FindObjectOfType<LevelControler>().HandelLoseCondition();
            
        }

    }
}
