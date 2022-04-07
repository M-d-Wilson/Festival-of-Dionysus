using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionHandler : MonoBehaviour
{
    public RandomQuestion randomQuestion;
    public string answerA, answerB, answerC, answerD;
    public bool correctA, correctB, correctC, correctD, questionAsked, answeredCorrect;
    public int num;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CallAdd()
    {
        num = Random.Range(0, 10);
        randomQuestion.MathAdd();
        questionAsked = true;
        if (num == 0)
        {
            answerA = randomQuestion.z.ToString();
            answerB = (randomQuestion.z + 1).ToString();
            answerC = randomQuestion.x.ToString();
            answerD = (Random.Range(0, 150)).ToString();
            correctA = true;
        }
        else if (num == 1)
        {
            answerB = randomQuestion.z.ToString();
            answerA = (randomQuestion.z + 1).ToString();
            answerC = randomQuestion.x.ToString();
            answerD = (Random.Range(0, 150)).ToString();
            correctB = true;
        }
        else if (num == 2)
        {
            answerC = randomQuestion.z.ToString();
            answerB = (randomQuestion.z + 1).ToString();
            answerA = randomQuestion.x.ToString();
            answerD = (Random.Range(0, 150)).ToString();
            correctC = true;
        }
        else if (num == 3)
        {
            answerD = randomQuestion.z.ToString();
            answerB = (randomQuestion.z + 1).ToString();
            answerC = randomQuestion.x.ToString();
            answerA = (Random.Range(0, 150)).ToString();
            correctD = true;
        }
        else if (num == 4)
        {
            answerA = randomQuestion.z.ToString();
            answerC = (randomQuestion.z + 1).ToString();
            answerB = randomQuestion.x.ToString();
            answerD = (Random.Range(0, 150)).ToString();
            correctA = true;
        }
        else if (num == 5)
        {
            answerA = randomQuestion.z.ToString();
            answerD = (randomQuestion.z + 1).ToString();
            answerC = randomQuestion.x.ToString();
            answerB = (Random.Range(0, 150)).ToString();
            correctA = true;
        }
        else if (num == 6)
        {
            answerA = randomQuestion.z.ToString();
            answerB = (randomQuestion.z + 1).ToString();
            answerD = randomQuestion.x.ToString();
            answerC = (Random.Range(0, 150)).ToString();
            correctA = true;
        }
        else if (num == 7)
        {
            answerB = randomQuestion.z.ToString();
            answerC = (randomQuestion.z + 1).ToString();
            answerD = randomQuestion.x.ToString();
            answerA = (Random.Range(0, 150)).ToString();
            correctB = true;
        }
        else if (num == 8)
        {
            answerC = randomQuestion.z.ToString();
            answerD = (randomQuestion.z + 1).ToString();
            answerA = randomQuestion.x.ToString();
            answerB = (Random.Range(0, 150)).ToString();
            correctC = true;
        }
        else if (num == 9)
        {
            answerD = randomQuestion.z.ToString();
            answerA = (randomQuestion.z + 1).ToString();
            answerB = randomQuestion.x.ToString();
            answerC = (Random.Range(0, 150)).ToString();
            correctD = true;
        }


    }

    public void CallSubtract()
    {
        num = Random.Range(0, 10);
        questionAsked = true;
        randomQuestion.MathSubtract();

        if (num == 0)
        {
            answerA = randomQuestion.z.ToString();
            answerB = (randomQuestion.z - 1).ToString();
            answerC = randomQuestion.x.ToString();
            answerD = (Random.Range(0, 150)).ToString();
            correctA = true;
        }
        else if (num == 1)
        {
            answerB = randomQuestion.z.ToString();
            answerA = (randomQuestion.z - 1).ToString();
            answerC = randomQuestion.x.ToString();
            answerD = (Random.Range(0, 150)).ToString();
            correctB = true;
        }
        else if (num == 2)
        {
            answerC = randomQuestion.z.ToString();
            answerB = (randomQuestion.z - 1).ToString();
            answerA = randomQuestion.x.ToString();
            answerD = (Random.Range(0, 150)).ToString();
            correctC = true;
        }
        else if (num == 3)
        {
            answerD = randomQuestion.z.ToString();
            answerB = (randomQuestion.z - 1).ToString();
            answerC = randomQuestion.x.ToString();
            answerA = (Random.Range(0, 150)).ToString();
            correctD = true;
        }
        else if (num == 4)
        {
            answerA = randomQuestion.z.ToString();
            answerC = (randomQuestion.z - 1).ToString();
            answerB = randomQuestion.x.ToString();
            answerD = (Random.Range(0, 150)).ToString();
            correctA = true;
        }
        else if (num == 5)
        {
            answerA = randomQuestion.z.ToString();
            answerD = (randomQuestion.z - 1).ToString();
            answerC = randomQuestion.x.ToString();
            answerB = (Random.Range(0, 150)).ToString();
            correctA = true;
        }
        else if (num == 6)
        {
            answerA = randomQuestion.z.ToString();
            answerB = (randomQuestion.z - 1).ToString();
            answerD = randomQuestion.x.ToString();
            answerC = (Random.Range(0, 150)).ToString();
            correctA = true;
        }
        else if (num == 7)
        {
            answerB = randomQuestion.z.ToString();
            answerC = (randomQuestion.z - 1).ToString();
            answerD = randomQuestion.x.ToString();
            answerA = (Random.Range(0, 150)).ToString();
            correctB = true;
        }
        else if (num == 8)
        {
            answerC = randomQuestion.z.ToString();
            answerD = (randomQuestion.z - 1).ToString();
            answerA = randomQuestion.x.ToString();
            answerB = (Random.Range(0, 150)).ToString();
            correctC = true;
        }
        else if (num == 9)
        {
            answerD = randomQuestion.z.ToString();
            answerA = (randomQuestion.z - 1).ToString();
            answerB = randomQuestion.x.ToString();
            answerC = (Random.Range(0, 150)).ToString();
            correctD = true;
        }

    }

    public void CallMultiply()
    {
        num = Random.Range(0, 10);
        randomQuestion.MathMultiply();
        questionAsked = true;

        if (num == 0)
        {
            answerA = randomQuestion.z.ToString();
            answerB = (randomQuestion.z + 1).ToString();
            answerC = randomQuestion.x.ToString();
            answerD = (Random.Range(0, 150)).ToString();
            correctA = true;
        }
        else if (num == 1)
        {
            answerB = randomQuestion.z.ToString();
            answerA = (randomQuestion.z + 1).ToString();
            answerC = randomQuestion.x.ToString();
            answerD = (Random.Range(0, 150)).ToString();
            correctB = true;
        }
        else if (num == 2)
        {
            answerC = randomQuestion.z.ToString();
            answerB = (randomQuestion.z + 1).ToString();
            answerA = randomQuestion.x.ToString();
            answerD = (Random.Range(0, 150)).ToString();
            correctC = true;
        }
        else if (num == 3)
        {
            answerD = randomQuestion.z.ToString();
            answerB = (randomQuestion.z + 1).ToString();
            answerC = randomQuestion.x.ToString();
            answerA = (Random.Range(0, 150)).ToString();
            correctD = true;
        }
        else if (num == 4)
        {
            answerA = randomQuestion.z.ToString();
            answerC = (randomQuestion.z + 1).ToString();
            answerB = randomQuestion.x.ToString();
            answerD = (Random.Range(0, 150)).ToString();
            correctA = true;
        }
        else if (num == 5)
        {
            answerA = randomQuestion.z.ToString();
            answerD = (randomQuestion.z + 1).ToString();
            answerC = randomQuestion.x.ToString();
            answerB = (Random.Range(0, 150)).ToString();
            correctA = true;
        }
        else if (num == 6)
        {
            answerA = randomQuestion.z.ToString();
            answerB = (randomQuestion.z + 1).ToString();
            answerD = randomQuestion.x.ToString();
            answerC = (Random.Range(0, 150)).ToString();
            correctA = true;
        }
        else if (num == 7)
        {
            answerB = randomQuestion.z.ToString();
            answerC = (randomQuestion.z + 1).ToString();
            answerD = randomQuestion.x.ToString();
            answerA = (Random.Range(0, 150)).ToString();
            correctB = true;
        }
        else if (num == 8)
        {
            answerC = randomQuestion.z.ToString();
            answerD = (randomQuestion.z + 1).ToString();
            answerA = randomQuestion.x.ToString();
            answerB = (Random.Range(0, 150)).ToString();
            correctC = true;
        }
        else if (num == 9)
        {
            answerD = randomQuestion.z.ToString();
            answerA = (randomQuestion.z + 1).ToString();
            answerB = randomQuestion.x.ToString();
            answerC = (Random.Range(0, 150)).ToString();
            correctD = true;
        }

    }

    public void CallDivide()
    {
        num = Random.Range(0, 10);
        randomQuestion.MathDivide();
        questionAsked = true;

        if (num == 0)
        {
            answerA = randomQuestion.z.ToString();
            answerB = (randomQuestion.z + 1).ToString();
            answerC = randomQuestion.x.ToString();
            answerD = (Random.Range(0, 150)).ToString();
            correctA = true;
        }
        else if (num == 1)
        {
            answerB = randomQuestion.z.ToString();
            answerA = (randomQuestion.z + 1).ToString();
            answerC = randomQuestion.x.ToString();
            answerD = (Random.Range(0, 150)).ToString();
            correctB = true;
        }
        else if (num == 2)
        {
            answerC = randomQuestion.z.ToString();
            answerB = (randomQuestion.z + 1).ToString();
            answerA = randomQuestion.x.ToString();
            answerD = (Random.Range(0, 150)).ToString();
            correctC = true;
        }
        else if (num == 3)
        {
            answerD = randomQuestion.z.ToString();
            answerB = (randomQuestion.z + 1).ToString();
            answerC = randomQuestion.x.ToString();
            answerA = (Random.Range(0, 150)).ToString();
            correctD = true;
        }
        else if (num == 4)
        {
            answerA = randomQuestion.z.ToString();
            answerC = (randomQuestion.z + 1).ToString();
            answerB = randomQuestion.x.ToString();
            answerD = (Random.Range(0, 150)).ToString();
            correctA = true;
        }
        else if (num == 5)
        {
            answerA = randomQuestion.z.ToString();
            answerD = (randomQuestion.z + 1).ToString();
            answerC = randomQuestion.x.ToString();
            answerB = (Random.Range(0, 150)).ToString();
            correctA = true;
        }
        else if (num == 6)
        {
            answerA = randomQuestion.z.ToString();
            answerB = (randomQuestion.z + 1).ToString();
            answerD = randomQuestion.x.ToString();
            answerC = (Random.Range(0, 150)).ToString();
            correctA = true;
        }
        else if (num == 7)
        {
            answerB = randomQuestion.z.ToString();
            answerC = (randomQuestion.z + 1).ToString();
            answerD = randomQuestion.x.ToString();
            answerA = (Random.Range(0, 150)).ToString();
            correctB = true;
        }
        else if (num == 8)
        {
            answerC = randomQuestion.z.ToString();
            answerD = (randomQuestion.z + 1).ToString();
            answerA = randomQuestion.x.ToString();
            answerB = (Random.Range(0, 150)).ToString();
            correctC = true;
        }
        else if (num == 9)
        {
            answerD = randomQuestion.z.ToString();
            answerA = (randomQuestion.z + 1).ToString();
            answerB = randomQuestion.x.ToString();
            answerC = (Random.Range(0, 150)).ToString();
            correctD = true;
        }

    }

    public void CallGreek()
    {
        num = Random.Range(0, 16);
        randomQuestion.GreekQuestion();
        questionAsked = true;
        if (num == 0)
        {
            answerA = randomQuestion.answer1;
            answerB = randomQuestion.answer2;
            answerC = randomQuestion.answer3;
            answerD = randomQuestion.answer4;
            correctA = true;
        }
        else if (num == 1)
        {
            answerB = randomQuestion.answer1;
            answerA = randomQuestion.answer2;
            answerC = randomQuestion.answer3;
            answerD = randomQuestion.answer4;
            correctB = true;
        }
        else if (num == 2)
        {
            answerC = randomQuestion.answer1;
            answerB = randomQuestion.answer2;
            answerA = randomQuestion.answer3;
            answerD = randomQuestion.answer4;
            correctC = true;
        }
        else if (num == 3)
        {
            answerD = randomQuestion.answer1;
            answerB = randomQuestion.answer2;
            answerC = randomQuestion.answer3;
            answerA = randomQuestion.answer4;
            correctD = true;
        }
        else if (num == 4)
        {
            answerA = randomQuestion.answer1;
            answerC = randomQuestion.answer2;
            answerB = randomQuestion.answer3;
            answerD = randomQuestion.answer4;
            correctA = true;
        }
        else if (num == 5)
        {
            answerA = randomQuestion.answer1;
            answerD = randomQuestion.answer2;
            answerC = randomQuestion.answer3;
            answerB = randomQuestion.answer4;
            correctA = true;
        }
        else if (num == 6)
        {
            answerA = randomQuestion.answer1;
            answerB = randomQuestion.answer2;
            answerD = randomQuestion.answer3;
            answerC = randomQuestion.answer4;
            correctA = true;
        }
        else if (num == 7)
        {
            answerB = randomQuestion.answer1;
            answerC = randomQuestion.answer2;
            answerD = randomQuestion.answer3;
            answerA = randomQuestion.answer4;
            correctB = true;
        }
        else if (num == 8)
        {
            answerC = randomQuestion.answer1;
            answerD = randomQuestion.answer2;
            answerA = randomQuestion.answer3;
            answerB = randomQuestion.answer4;
            correctC = true;
        }
        else if (num == 9)
        {
            answerD = randomQuestion.answer1;
            answerA = randomQuestion.answer2;
            answerB = randomQuestion.answer3;
            answerC = randomQuestion.answer4;
            correctD = true;
        }
    }
    public void CallRandom()
    {
        num = Random.Range(0, 5);
        switch (num)
        {
            case 4:
                CallAdd();
                break;
            case 3:
                CallSubtract();
                break;
            case 2:
                CallMultiply();
                break;
            case 1:
                CallDivide();
                break;
            default:
                CallGreek();
                break;
        }
    }

    public void OnGUI()
    {
        if (questionAsked)
        {
            GUI.Box(new Rect(Screen.width / 10f, Screen.height / 15, Screen.width / 2f, Screen.height / 15f), randomQuestion.question);
            if (GUI.Button(new Rect(Screen.width / 10f, Screen.height / 8f, Screen.width / 10f, Screen.height / 10f), answerA))
            {
                if (correctA)
                {
                    answeredCorrect = true;
                    questionAsked = false;
                    correctA = false;
                }
            }
            if (GUI.Button(new Rect(Screen.width / 5f, Screen.height / 8f, Screen.width / 10f, Screen.height / 10f), answerB))
            {
                if (correctB)
                {
                    answeredCorrect = true;
                    questionAsked = false;
                    correctB = false;
                }
            }
            if (GUI.Button(new Rect(Screen.width / 10f, Screen.height / 4f, Screen.width / 10f, Screen.height / 10f), answerC))
            {
                if (correctC)
                {
                    answeredCorrect = true;
                    questionAsked = false;
                    correctC = false;
                }
            }
            if (GUI.Button(new Rect(Screen.width / 5f, Screen.height / 4f, Screen.width / 10f, Screen.height / 10f), answerD))
            {
                if (correctD)
                {
                    answeredCorrect = true;
                    questionAsked = false;
                    correctD = false;
                }
            }

        }
       
    }
}
