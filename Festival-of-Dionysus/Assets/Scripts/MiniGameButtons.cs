using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject Game1, Player1, Game2;

    public void StartGame1()
    {
        Player1.SetActive(true);
        Game1.SetActive(true);
    }

    public void StartGame2()
    {
        Game2.SetActive(true);
    }
}
