using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)]
    float fltCurrentSpeed = 1f;
    GameObject currentTarget;
    //current target for attached method
    
    void Update()
    {
        // speed to move attacker
        transform.Translate(Vector2.left * fltCurrentSpeed * Time.deltaTime);
    } // Update

    public void SetMovementSpeed(float speed)
    {
        fltCurrentSpeed = speed;
    }
    public void Attack(GameObject objTarget)
    {
        GetComponent<Animator>().SetBool("isAttacking",true);
        currentTarget = objTarget;
    }

} // Attacker

