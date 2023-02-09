using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButton : MonoBehaviour
{
    public GameObject plateforme;
    public GameObject other;


    bool isOpened = false;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (isOpened == false)
        {
            isOpened = true;
            plateforme.gameObject.transform.position += new Vector3(0, 5, 0);
            Destroy(other);
        }

    }




}
