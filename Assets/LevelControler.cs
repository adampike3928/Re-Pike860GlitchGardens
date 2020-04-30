using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControler : MonoBehaviour
{
    int intNumberOfAttackers = 0;
    bool levelTimerFinished = false; 
    public void AttackerSpawned()
    {
        intNumberOfAttackers++;
    }
    public void AttackerKilled()
    {
        intNumberOfAttackers--;
        if(intNumberOfAttackers <= 0 && levelTimerFinished)
        {
            Debug.Log("End Now");
        }

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
