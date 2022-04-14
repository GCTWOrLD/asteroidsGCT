using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaisseauTirailleur : MonoBehaviour
{
    public float movementSpeed = 5f, rotationSpeed = 150f;
    public int vieMax = 50;
    public GameObject missile, canonLeft, canonRight;

    private Transform joueur;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootMissles", 1.0f, 1.0f);
        joueur = GameObject.Find("PlayerShip").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(joueur);
    }

    void ShootMissles()
    {
        Instantiate(missile, canonLeft.transform.position, canonLeft.transform.rotation);
        Instantiate(missile, canonRight.transform.position, canonRight.transform.rotation);
    }

    void Esquive()
    {
        
    }


}
