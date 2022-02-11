using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] GameManager gm;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Finished!");
            // Play particles
            GetComponentInChildren<ParticleSystem>().Play();

            // Play sound
            GetComponent<AudioSource>().Play();

            // Reload scene
            gm.Invoke("ReloadScene", loadDelay);

            // Set Player canMove to false
            GetComponent<PlayerController>().DisableControls();
        }
    }
}
