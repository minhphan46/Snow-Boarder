using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;
    int currentSceneIndex = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            finishEffect.Play();
            Invoke("RestartGame", loadDelay); // wait 2 seconds before restarting the game
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }
}
