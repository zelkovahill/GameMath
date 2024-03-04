using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnrefactoredPlayer : MonoBehaviour
{
    [SerializeField] private string inputAxisName;
    [SerializeField] private float positionMultiplier;
    private float yPosition;
    private AudioSource bounceSound;

    private void Start()
    {
        bounceSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        float delta = Input.GetAxis(inputAxisName) * Time.deltaTime;
        yPosition = Mathf.Clamp(yPosition + delta, -1, 1);
        
        transform.position =new Vector3(transform.position.x,yPosition*
                                                             positionMultiplier,transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        bounceSound.Play();
    }
}
