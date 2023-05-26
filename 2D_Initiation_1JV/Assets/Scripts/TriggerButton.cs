using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButton : MonoBehaviour
{
    public GameObject plateforme;
    public GameObject other;


    bool isMoving = false;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (isMoving == false)
        {
            isMoving = true;
            plateforme.gameObject.transform.position += new Vector3(0, -50, 0);
            Destroy(other);
        }

    }




}
