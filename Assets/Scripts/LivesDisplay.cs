using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LivesDisplay : MonoBehaviour
{
    [SerializeField] int intLives = 5;
    [SerializeField] int intDamage = 1;
    Text livesText;
    // Start is called before the first frame update
    void Start()
    {
        livesText = GetComponent<Text>();
        UpdateDisplay();
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
            FindObjectOfType<LevelLoad>().LoadYouLose();
        }

    }
}
