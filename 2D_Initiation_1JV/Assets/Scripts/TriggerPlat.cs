  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TriggerPlat : MonoBehaviour
{

    public GameObject plateforme;
    public MovingPlatformScript moving;
    private SpriteRenderer CouleurObjet;
    public SpriteRenderer CouleurPlatform;
    

    void Start()
    {
       
        moving.isMoving = false;
        
    } 

    void OnTriggerEnter2D(Collider2D collision)
    {
        CouleurObjet = collision.GetComponent<SpriteRenderer>();

        if (moving.isMoving == false && CouleurObjet.color != CouleurPlatform.color )
        {
            moving.isMoving = true;
       
        }


    }
}
