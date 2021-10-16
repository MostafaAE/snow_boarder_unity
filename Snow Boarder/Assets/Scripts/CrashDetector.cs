using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField]
    float delayTime = 1f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Invoke("ReloadScene", delayTime);
    }


    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}