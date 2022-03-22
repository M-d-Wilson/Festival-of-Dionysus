using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedusaGameButtons : MonoBehaviour
{
    [SerializeField]
    private RectTransform Player1, Player2;

    public void MovePlayer1()
    {
        Vector3 vector3 = new Vector3(Player1.localPosition.x - Random.Range(7, 10), Player1.localPosition.y, Player1.localPosition.z);
        Player1.localPosition = vector3;
    }

    public void MovePlayer2()
    {
        Vector3 vector3 = new Vector3(Player2.position.x - Random.Range(7, 10), Player2.position.y, Player2.position.z);
        Player2.position = vector3;
    }
}
