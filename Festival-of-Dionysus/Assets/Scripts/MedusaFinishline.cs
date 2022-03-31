using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedusaFinishline : MonoBehaviour
{
    [SerializeField]
    private GameObject Game, Player1, Player2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player1.GetComponent<MedusaPlayer>().ResetPos();
            Player2.GetComponent<MedusaPlayer>().ResetPos();
            Game.SetActive(false);
            Debug.Log("Game Won");
        }
    }
}
