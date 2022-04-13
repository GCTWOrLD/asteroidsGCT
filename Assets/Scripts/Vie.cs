using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vie : MonoBehaviour
{
    private int totalVie;
    private int vieMax;

    public Vie(int vieMax)
    {
        this.vieMax = vieMax;
        totalVie = vieMax;
    }

    public int GetTotalVie()
    {
        return totalVie;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Degat(int nbDegat)
    {
        totalVie -= nbDegat;
        if (totalVie < 0)
        {
            totalVie = 0;
        }
    }

    public void Soin(int nbSoin)
    {
        totalVie += nbSoin;
        if (totalVie > vieMax)
        {
            totalVie = vieMax;
        }
    }
}
