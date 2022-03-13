using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMiniGame : MonoBehaviour
{
    [SerializeField]
    private GameObject Game, player, enemy;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetComponent<Labyrinth_Player>().ResetPos();
            enemy.GetComponent<Labyrinth_Enemy>().ResetPos();
            Game.SetActive(false);
            Debug.Log("Game Won");
        }
    }
}
