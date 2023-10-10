using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthWatcher : MonoBehaviour
{
    public CharacterBrain characterbrain;
    public TextMeshProUGUI HealthText;

    // Update is called once per frame
    void Update()
    {
        HealthText.text = "Health: " + characterbrain.health.ToString();
    }
}
