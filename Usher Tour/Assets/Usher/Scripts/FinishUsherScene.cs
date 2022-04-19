using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishUsherScene : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerCharacterController>();
        // test if the other collider contains a PlayerCharacterController, then complete
        if (player != null)
        {
            Animator door_anim = GameObject.Find("Bloody_Door").GetComponent<Animator>() as Animator;
            door_anim.SetBool("open", true);
            GameObject.Find("LevelLoader").GetComponent<LevelLoader>().LoadNextLevel();
        }
    }
}
