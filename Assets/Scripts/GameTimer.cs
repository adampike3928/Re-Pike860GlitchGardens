using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level timer in Seconds")]
    [SerializeField] float fltLevelTime = 10;
    //set timer

    // Update is called once per frame
    void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / fltLevelTime;
        //Equation for how much of the slider to fill
        bool timerFinished = (Time.timeSinceLevelLoad >= fltLevelTime);
        if (timerFinished)
        {
            Debug.Log("Level timer expired");
        }
    
    }
}
