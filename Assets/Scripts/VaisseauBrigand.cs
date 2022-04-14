using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VaisseauBrigand : MonoBehaviour
{
    public float movementSpeed = 1.5f, rotationSpeed = 100f;
    // Doté de plusieurs points de vie
    public int vieMax = 150;
    private Transform joueur;

    // Start is called before the first frame update
    void Start()
    {
        joueur = GameObject.Find("PlayerShip").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Cherche constamment à se diriger vers la position du joueur
        transform.LookAt(joueur);
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Subira des dommages s'il entre en collision avec un astéroide ou joueur (fonctionne seulement avec astéroide)
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
