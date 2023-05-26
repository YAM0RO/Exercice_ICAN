using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatTrigger : MonoBehaviour
{
    public GameObject button;
    public MovingPlatformScript movingscript;
    private bool accestrigger = false;

    private void Start()
    {
        accestrigger = false;
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (accestrigger == false)
        {
            accestrigger = true;
            movingscript.StartMoving();
        }

    }




}