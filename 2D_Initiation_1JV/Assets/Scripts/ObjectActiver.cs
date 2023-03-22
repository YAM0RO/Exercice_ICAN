using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActiver : MonoBehaviour
{
    public GameObject objet;


    bool isOpened = false;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (isOpened == false)
        {
            isOpened = true;
            objet.SetActive(true);
        }

    }




}
