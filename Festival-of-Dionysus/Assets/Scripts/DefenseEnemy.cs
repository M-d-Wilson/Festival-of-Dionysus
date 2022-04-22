using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenseEnemy : MonoBehaviour
{
    [SerializeField]
    private RectTransform pos;
    [SerializeField]
    private float speed, answer;
    [SerializeField]
    private Text problem;
    [SerializeField]
    private RandomQuestion questions;
    [SerializeField]
    private bool dying;

    public void setSpeed(float x)
    {
        speed = x;
    }

    public void setQuestions(RandomQuestion x)
    {
        questions = x;
    }

    void Start()
    {
        //assigns varibles
        pos = GetComponent<RectTransform>();
        problem = GetComponentInChildren<Text>();
        //makes question if the question
        if (questions != null)
        {
            questions.MathAdd();
            problem.text = questions.question.Substring(8);
        }
        dying = false;
        if(questions != null)
            answer = questions.z;
    }

    void FixedUpdate()
    {
        //makes question if the question has not been made yet
        if (questions != null && problem.text == "")
        {
            questions.MathAdd();
            problem.text = questions.question.Substring(8);
        }

        if (!dying)
        {
            //moves the Enemy Forward
            pos.Translate(new Vector3((speed * Time.deltaTime), 0, 0));
        }
        else
        {
            //moves the Enemy to die off screen
            pos.Translate(new Vector3((400 * Time.deltaTime), (500 * Time.deltaTime), 0));
        }
    }

    public bool Answer(int ans)
    {
        //checks if answer is right
        if(ans == answer)
        {
            //begins dying sequence if is dying
            dying = true;
            Destroy(this.gameObject, 1f);
            return true;
        }
        return false;
    }

    public bool HitBase()
    {
        dying = true;
        Destroy(this.gameObject, 1f);
        return true;
    }

    public bool Die()
    {
        Destroy(this.gameObject);
        return true;
    }
}
