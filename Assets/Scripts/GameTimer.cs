using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level timer in Seconds")]
    [SerializeField] float fltLevelTime = 10;
    //set timer
    bool triggeredLevelFinished = false;
    // Update is called once per frame
    void Update()
    {
        if (triggeredLevelFinished) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / fltLevelTime;
        //Equation for how much of the slider to fill
        bool timerFinished = (Time.timeSinceLevelLoad >= fltLevelTime);
        if (timerFinished)
        {
            FindObjectOfType<LevelControler>().LevelTimerFinished();
            triggeredLevelFinished = true;
        }
    
    }
}
