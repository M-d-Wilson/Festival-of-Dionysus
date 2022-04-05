using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labyrinth_Region : MonoBehaviour
{
    GameObject[] wallsInRegion;

    public void ActivateRegion()
    {
        foreach(GameObject wall in wallsInRegion)
        {
            wall.SetActive(true);
        }
    }

    public void DeactivateRegion()
    {
        foreach (GameObject wall in wallsInRegion)
        {
            wall.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ActivateRegion();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        DeactivateRegion();
    }
}
