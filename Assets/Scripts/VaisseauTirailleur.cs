using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaisseauTirailleur : MonoBehaviour
{
    public float movementSpeed = 3f, rotationSpeed = 100f;
    public GameObject missile, canonLeft, canonRight;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootMissles", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void ShootMissles()
    {
        Instantiate(missile, canonLeft.transform.position, canonLeft.transform.rotation);
        Instantiate(missile, canonRight.transform.position, canonRight.transform.rotation);
    }
}
