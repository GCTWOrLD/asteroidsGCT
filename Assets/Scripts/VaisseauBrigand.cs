using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VaisseauBrigand : MonoBehaviour
{
    public float movementSpeed = 1.5f, rotationSpeed = 100f;
    private int vieMax = 150;
    private Transform joueur;

    // Start is called before the first frame update
    void Start()
    {
        //Vie vie = new Vie(vieMax);
        joueur = GameObject.Find("PlayerShip").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(joueur);
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }
}
