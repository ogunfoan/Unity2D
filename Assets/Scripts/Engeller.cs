using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Engeller : MonoBehaviour
{
    private SceneManager _sceneManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Engel"))
        {
            Destroy(other.gameObject);
            ToplamVeriler.Eksican++;
        }
    }
}
