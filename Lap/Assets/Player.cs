using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   [SerializeField] private PlayerAudio playerAudio;
   [SerializeField] private PlayerInput playerInput;
   [SerializeField] private PlayerMovement playerMovement;

   private void Start()
   {
      playerAudio = GetComponent<PlayerAudio>();
      playerInput = GetComponent<PlayerInput>();
      playerMovement = GetComponent<PlayerMovement>();
   }
}

public class PlayerAudio : MonoBehaviour
{
      
}

public class PlayerInput : MonoBehaviour
{
      
}

public class PlayerMovement : MonoBehaviour
{
      
}


