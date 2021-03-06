using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] GameManager gm;
    [SerializeField] ParticleSystem crashParticles;
    [SerializeField] AudioClip crashSFX;
    bool crashed = false;

    private void Start() {
        crashed = false;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground" && !crashed)
        {
            Debug.Log("Crashed! HOWCAN");

            // Play particles
            crashParticles.Play();

            // Play sound
            GetComponent<AudioSource>().PlayOneShot(crashSFX);

            // Reload scene
            gm.Invoke("ReloadScene", loadDelay);

            // Stop moving
            GetComponent<PlayerController>().DisableControls();

            crashed = true;
        }
    }
}
