using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplanabilirler : MonoBehaviour
{
    private int say = 0;
    [SerializeField] private AudioClip ToplamaSesi;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Kek"))
        {
            AudioSource.PlayClipAtPoint(ToplamaSesi, other.transform.position);
            say++; 
            Destroy(other.gameObject);
        }
    }
}
