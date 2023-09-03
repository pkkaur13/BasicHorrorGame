using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class keys : MonoBehaviour
{
    int totalKeys;
    int collectedKeys = 0;
    public string sceneName;
    

    [SerializeField] Text coinsText; 
    [SerializeField] GameObject gameOverPanel; // Reference to the game over panel

    private void Start()
    {
        // Count the total number of keys in the scene
        totalKeys = GameObject.FindGameObjectsWithTag("keys").Length;
        UpdateKeysText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("keys"))
        {
            Destroy(other.gameObject);
            collectedKeys++;
            UpdateKeysText();

            // Check if all keys are collected
            if (collectedKeys == totalKeys)
            {
                // All keys are collected, trigger game end
                GameEnd();
            }
        }
    }

    private void UpdateKeysText()
    {
        coinsText.text = "Keys Found: " + collectedKeys + " / " + totalKeys;
    }

    private void GameEnd()
    {
        // Display the game over panel or perform any other game-ending actions
        gameOverPanel.SetActive(true);
        
    }
   
}
