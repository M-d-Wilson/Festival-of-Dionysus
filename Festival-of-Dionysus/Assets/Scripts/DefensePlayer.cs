using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefensePlayer : MonoBehaviour
{
    [SerializeField]
    int answersToWin, correctAnswers, startHealth, health;
    [SerializeField]
    private Text answer;
    [SerializeField]
    DefenseSpawner Spawner;
    [SerializeField]
    GameObject game;
    [SerializeField]
    private DefenseLives lives;
    [SerializeField]
    bool win, lose, spawnsStoped;
    [SerializeField]
    float endGameTimer, endGameTimeLimit;

    public int GetHealth()
    {
        return health;
    }

    private void OnEnable()
    {
        endGameTimer = 0;
        correctAnswers = 0;
        health = startHealth;
        win = false;
        lose = false;
        spawnsStoped = false;
    }

    private void FixedUpdate()
    {

        if (win)
        {
            if (!spawnsStoped)
            {
                Spawner.StopSpawns();
                spawnsStoped = true;
            }
            endGameTimer += Time.deltaTime;
            //display win stuff
            if (endGameTimer > endGameTimeLimit)
            {
                endGameTimer = 0;
                game.SetActive(false);
            }
        }else if(lose)
        {
            endGameTimer += Time.deltaTime;
            //dipaly lose stuff
            if (endGameTimer > endGameTimeLimit)
            {
                endGameTimer = 0;
                game.SetActive(false);
            }
        }
    }

    public void TryAnswer()
    {
        if (!win && !lose)
        {
            if (Spawner.checkAnswers(int.Parse(answer.text)))
            {
                //Debug.Log("Correct");
                correctAnswers++;
                if (correctAnswers >= answersToWin)
                {
                    //Win game
                    Debug.Log("Win game");
                    win = true;
                }
            }
            answer.text = "";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    { 
        //Debug.Log("Hit");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health--;
            lives.UpdateText();
            if (health <= 0)
            {
                //Lose game
                Debug.Log("Lose game");
                lose = true;
                return;
            }
            collision.gameObject.GetComponent<DefenseEnemy>().HitBase();
        }
    }
}
