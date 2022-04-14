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
        // Tire p�ridiquement des missiles 
        InvokeRepeating("ShootMissles", 1.0f, 1.0f);
        joueur = GameObject.Find("PlayerShip").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // En direction du joueur
        transform.LookAt(joueur);
    }

    void ShootMissles()
    {
        Instantiate(missile, canonLeft.transform.position, canonLeft.transform.rotation);
        Instantiate(missile, canonRight.transform.position, canonRight.transform.rotation);
    }

    // Cherche � maintenir une distance minimum entre lui et le joueur
    void Esquive()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Subira des dommages s'il entre en collision avec un ast�roide ou joueur (fonctionne seulement avec ast�roide)
        if (other.gameObject.CompareTag("Asteroid"))
        {
            Debug.Log("Collision Asteroid");
            Destroy(other.gameObject);
            vieMax -= 25;
            if (vieMax == 0)
            {
                Destroy(gameObject);
            }
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision Player");
            vieMax -= 25;
            if (vieMax == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
