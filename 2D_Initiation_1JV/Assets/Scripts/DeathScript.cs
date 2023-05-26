using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
  
    public CharacterController2D Player;
    public CharacterController2D Player2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.Die();
        Player2.Die();



    }
}
