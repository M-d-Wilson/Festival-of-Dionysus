using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labyrinth_WallActivator : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] walls = GameObject.FindGameObjectsWithTag("Region");
        foreach (GameObject wall in walls)
        {

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Region"))
        {
            
        }
    }
}
