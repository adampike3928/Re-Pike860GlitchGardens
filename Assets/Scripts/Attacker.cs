using System;
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
        UpdateAnimationState();
    } // Update

    private void UpdateAnimationState()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("IsAttacking", false);
            //If target not found, stop attacking
        }
    }

    public void SetMovementSpeed(float speed)
    {
        fltCurrentSpeed = speed;
    }
    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("IsAttacking",true);
        currentTarget = target;
    }
    public void StrikeCurrentTarget(float fltDamage)
    {
        if (!currentTarget) { return; }
        Health health = currentTarget.GetComponent<Health>();
        if (health)
        {
            health.DealDamage(fltDamage);

        }
    }//if it has health, damage it

} // Attacker

