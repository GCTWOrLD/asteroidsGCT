using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float movementSpeed = 5f, rotationSpeed = 150f;
    public int vieMax = 100;
    public int nbPointsTirailleur = 3;
    public int nbPointsAsteroid = 1;

    public GameObject missile, canon;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        transform.Rotate(0, 0, -rotation * Time.deltaTime);

        float translation = Input.GetAxis("Vertical") * movementSpeed;
        transform.Translate(0, translation*Time.deltaTime, 0, Space.Self);

        var newPos = transform.position;
        newPos.x = Mathf.Clamp(newPos.x, -9, 9);
        newPos.y = Mathf.Clamp(newPos.y, -5, 5);
        transform.position = newPos;

        if (Input.GetKeyDown("space"))
        {
            Instantiate(missile, canon.transform.position, canon.transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Instantiate(explosion, other.transform.position, other.transform.rotation);
        if (other.gameObject.CompareTag("Asteroid"))
        {
            Destroy(other.gameObject);
            ScoreManager.Instance.AddScore(nbPointsAsteroid);
            vieMax -= 25;
        } 
        else if (other.gameObject.CompareTag("Brigand"))
        {
            vieMax -= 50;
        }
        else if (other.gameObject.CompareTag("Tirailleur"))
        {
            Destroy(other.gameObject);
            ScoreManager.Instance.AddScore(nbPointsTirailleur);
            vieMax -= 50;
        }
        else if (other.gameObject.CompareTag("Soin"))
        {
            Destroy(other.gameObject);
            vieMax += 25;
            if (vieMax > 100)
            {
                vieMax = 100;
            }
        }
        else if (other.gameObject.CompareTag("MissleT"))
        {
            vieMax -= 25;
        }

        if (vieMax <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }
}
