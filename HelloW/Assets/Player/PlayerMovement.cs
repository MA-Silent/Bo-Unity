using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 4;
    private Animator _animator;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    /*
        Hier komt het volgende blok code
    */
    void Update()
    {
        Vector3 movement = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            movement += transform.forward * movementSpeed * Time.deltaTime;
            _animator.SetFloat("speed", 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement -= transform.forward * movementSpeed * Time.deltaTime;
        }
        transform.position += movement.normalized * movementSpeed * Time.deltaTime;
    }
}