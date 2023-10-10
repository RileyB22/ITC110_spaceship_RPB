using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUpScript : MonoBehaviour
{

    public CharacterBrain characterbrain;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag ("Player")) 
        {
            characterbrain.health++;
            Destroy(this.gameObject);
        }
    }
}
