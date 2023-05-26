using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalChoice : MonoBehaviour
{
    public GameObject destroyfloor;
    public GameObject button;

   void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(destroyfloor);
        Destroy(button);
    }
}
