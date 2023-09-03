using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cutsceneCam, player;
    public float Cutscenetime;
    void Start()
    {
         StartCoroutine(cutscene( ));
    }
    IEnumerator cutscene()
    {
        yield return new WaitForSeconds(Cutscenetime);
        player.SetActive(true);
        cutsceneCam.SetActive(false);
            }

}
