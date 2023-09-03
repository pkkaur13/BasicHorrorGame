using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
   public GameObject pausemenu;
   public string sceneName;
   public bool toggle;
   public SC_FPSController playerScript;

   void Update()  // The method name should be "Update" with an uppercase 'U'
   {
    if (Input.GetKeyDown(KeyCode.Escape))
    {
        toggle = !toggle;
        if (toggle == false) 
        {
            pausemenu.SetActive(false);
            Time.timeScale = 1;
            playerScript.enabled = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else  // Instead of another if statement, use 'else' here
        {
            pausemenu.SetActive(true);
            Time.timeScale = 0;
            playerScript.enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
   }
   public void ResumeGame()  // Method names should start with an uppercase letter
   {
    toggle = false;
    pausemenu.SetActive(false);
    Time.timeScale = 1;
    playerScript.enabled = true;
    Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
   }
   public void QuitToMenu()  // Method names should start with an uppercase letter
   {
    Time.timeScale = 1;
    SceneManager.LoadScene(sceneName);
   }
}
