using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaisseauBrigand : MonoBehaviour
{
    public float movementSpeed = 3f, rotationSpeed = 100f;
    private int vieMax = 150;

    // Start is called before the first frame update
    void Start()
    {
        Vie vie = new Vie(vieMax);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
