using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TexteVie : MonoBehaviour
{
    private Text texteVie;
    private GameObject joueur;

    // Start is called before the first frame update
    void Start()
    {
        joueur = GameObject.FindGameObjectWithTag("Player");
        texteVie = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        texteVie.text = "Vie: " + joueur.GetComponent<Player>().vieMax.ToString();
    }
}
