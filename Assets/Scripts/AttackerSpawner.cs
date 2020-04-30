using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackerSpawner : MonoBehaviour
{

    [SerializeField] float fltMinSpawnDelay = 2f;
    [SerializeField] float fltMaxSpawnDelay = 5f;
    [SerializeField] Attacker[] attackerPrefabArray;

    bool boolSpawn = true; 

    IEnumerator Start()
    {
        while (boolSpawn)
        { 
            // delay before spawning
            yield return new WaitForSeconds(UnityEngine.Random.Range(fltMinSpawnDelay, fltMaxSpawnDelay));
            SpawnAttacker();
        } // while
    } // Start()

    public void StopSpawning()
    {
        boolSpawn = false;
    }

    private void SpawnAttacker()
    {
        var attackerIndex = UnityEngine.Random.Range(0, attackerPrefabArray.Length);
        Spawn(attackerPrefabArray[attackerIndex]);
       
        
       
    } 
    private void Spawn (Attacker myAttacker)
    {
        Attacker newAttacker = Instantiate
            (myAttacker, transform.position, transform.rotation)
            as Attacker;

        newAttacker.transform.parent = transform;
    }
} // class AttackerSpawner
