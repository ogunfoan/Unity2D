using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Toplanabilirler : MonoBehaviour
{
    [SerializeField] private AudioClip ToplamaSesi;
    [SerializeField] public TextMeshPro _text;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Kek"))
        {
            AudioSource.PlayClipAtPoint(ToplamaSesi, other.transform.position);
            ToplamVeriler.Skor++; 
            Destroy(other.gameObject);
            _text.text = ToplamVeriler.Skor.ToString();
        }
    }
}
