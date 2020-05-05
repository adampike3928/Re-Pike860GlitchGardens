using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;
        //Changes to sensing object, to sensing colider on said object
        if (otherObject.GetComponent<Gravestone>())
            //checks for defender script
        {
            GetComponent<Animator>().SetTrigger("JumpTrigger");
        }
        else if (otherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherObject);
        }
    
    
    
    
    }
}
