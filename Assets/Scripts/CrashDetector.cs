using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] GameManager gm;
    [SerializeField] ParticleSystem crashParticles;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            Debug.Log("Crashed! HOWCAN");
            gm.Invoke("ReloadScene", loadDelay);
            crashParticles.Play();
        }
    }
}
