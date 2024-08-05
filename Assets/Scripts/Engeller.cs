using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Engeller : MonoBehaviour
{
    private SceneManager _sceneManager;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Engel"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Destroy(other.gameObject);
        }
    }
}
