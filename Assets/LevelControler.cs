using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControler : MonoBehaviour
{
    [SerializeField] float waitToLoad = 4f;
    [SerializeField] GameObject winLable;
    [SerializeField] GameObject loseLabel;
    int intNumberOfAttackers = 0;
    bool levelTimerFinished = false;

    private void Start()
    {
        winLable.SetActive(false);
        loseLabel.SetActive(false);
    }
    //Makeing sure these don't load in when game starts
    public void AttackerSpawned()
    {
        intNumberOfAttackers++;
    }
    public void AttackerKilled()
    {
        intNumberOfAttackers--;
        if(intNumberOfAttackers <= 0 && levelTimerFinished)
        {
            StartCoroutine(HandleWinCondition());

        }

    }

    IEnumerator HandleWinCondition()
    {
        winLable.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(waitToLoad);
        FindObjectOfType<LevelLoad>().LoadNextScene();
    }

    public void HandelLoseCondition()
    {
        loseLabel.SetActive(true);
        Time.timeScale = 0;
    }


    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }
    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            
        }

    }



}
