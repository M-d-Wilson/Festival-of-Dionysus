using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionRooms : MonoBehaviour
{
    [SerializeField]
    private bool QuestionOnce = true;

    private void Awake()
    {
        QuestionOnce = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && QuestionOnce)
        {
            QuestionOnce = false;
            RunQuestion();
        }
    }

    private void RunQuestion()
    {
        Debug.Log("Run Question");
    }
}