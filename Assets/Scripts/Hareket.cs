using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{ 
    [SerializeField] private float hiz = 10f; 
    //serializefield unity editörde daha kolay kontrol sağlıyor
    [SerializeField] private float ziplamaGucu = 10f;
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    
    private bool Yerdemi;
    private bool OyunBasladiginda;
    private bool Ziplama;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>(); //caching, ramde daha hızlı 
        _animator = GetComponent<Animator>();
        Yerdemi = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (Yerdemi && OyunBasladiginda)
            {
                _animator.SetTrigger("Ziplama");
                Yerdemi = false;
                Ziplama = true;
            }
            else
            {
                _animator.SetBool("OyunBasladiginda",true);
                OyunBasladiginda = true;
            }
        }

        _animator.SetBool("Yerdemi",Yerdemi);
    }

    private void FixedUpdate()
    {
        if (OyunBasladiginda)
        {
            _rigidbody2D.velocity = new Vector2(hiz, _rigidbody2D.velocity.y);
        }

        if (Ziplama)
        {
            _rigidbody2D.AddForce(new Vector2(0f, ziplamaGucu));
            Ziplama = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Zemin"))
        {
            Yerdemi = true;
        }
    }
}
