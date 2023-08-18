using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem crashEffect;
    int currentSceneIndex = 0;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            crashEffect.Play();
            Invoke("RestartGame", loadDelay); // wait 2 seconds before restarting the game
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }
}
