using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightswitch : MonoBehaviour
{
    public GameObject inttext, light;
    public bool toggle = true, interactable;
    public Renderer lightBulb;
    public Material offlight, onlight;
    public AudioSource lightSwitchSound;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(true);
            interactable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(false);
            interactable = false;
        }
    }

    void Update()  // Note the capital "U" in Update
    {
        if (interactable)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                toggle = !toggle;
                if (toggle)
                {
                    light.SetActive(true);
                    lightBulb.material = onlight;
                    lightSwitchSound.Play();  // Play the sound when turning the light on
                }
                else
                {
                    light.SetActive(false);
                    lightBulb.material = offlight;
                    lightSwitchSound.Play();  // Play the sound when turning the light off
                }
            }
        }
    }
}
