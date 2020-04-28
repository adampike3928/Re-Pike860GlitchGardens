using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;
        //Changes to sensing object, to sensing colider on said object
        if (otherObject.GetComponent<Defender>())
            //checks for defender script
        {
            GetComponent<Attacker>().Attack(otherObject);
        }
    }
}
