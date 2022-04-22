using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject Game1, LaybrinthPlayer, Game2, Game3, DefencePlayer;

    public void StartGame1()
    {
        LaybrinthPlayer.SetActive(true);
        Game1.SetActive(true);
    }

    public void StartGame2()
    {
        Game2.SetActive(true);
    }

    public void StartGame3()
    {
        DefencePlayer.SetActive(true);
        Game3.SetActive(true);
    }
}
