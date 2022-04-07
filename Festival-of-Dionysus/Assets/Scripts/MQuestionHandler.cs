using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MQuestionHandler : MonoBehaviour
{
    public RandomQuestion rH;
    public Text A1, B1, C1, D1, question1, A2, B2, C2, D2, question2;
    private int num;
    bool mathQuestion, correctA1, correctB1, correctC1, correctD1, correctA2, correctB2, correctC2, correctD2, assignOne, assignTwo;
    public MedusaGameButtons mGB;
    // Start is called before the first frame update
    void Start()
    {
        AssignOne();
        AssignTwo();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q) && correctA1)
        {
            mGB.MovePlayer1();
            correctA1 = false;
            AssignOne();
        }
        else if(Input.GetKey(KeyCode.W) && correctB1)
        {
            mGB.MovePlayer1();
            correctB1 = false;
            AssignOne();
        }
        else if(Input.GetKey(KeyCode.A) && correctC1)
        {
            mGB.MovePlayer1();
            correctC1 = false;
            AssignOne();
        }
        else if(Input.GetKey(KeyCode.S) && correctD1)
        {
            mGB.MovePlayer1();
            correctD1 = false;
            AssignOne();
        }

        if (Input.GetKey(KeyCode.I) && correctA2)
        {
            mGB.MovePlayer2();
            correctA2 = false;
            AssignTwo();
        }
        else if (Input.GetKey(KeyCode.O) && correctB2)
        {
            mGB.MovePlayer2();
            correctB2 = false;
            AssignTwo();
        }
        else if (Input.GetKey(KeyCode.K) && correctC2)
        {
            mGB.MovePlayer2();
            correctC2 = false;
            AssignTwo();
        }
        else if (Input.GetKey(KeyCode.L) && correctD2)
        {
            mGB.MovePlayer2();
            correctD2 = false;
            AssignTwo();
        }
    }

    void AssignOne()
    {
        assignOne = true;
        RandomCall();
        RandomizeChoice();
        question1.text = rH.question;
        assignOne = false;
    }

    void AssignTwo()
    {
        assignTwo = true;
        RandomCall();
        RandomizeChoice();
        question2.text = rH.question;
        assignTwo = false;
    }

    void RandomizeChoice()
    {
        if (assignOne)
        {
            if (mathQuestion)
            {
                num = Random.Range(0, 10);


                if (num == 0)
                {
                    A1.text = rH.z.ToString();
                    B1.text = (rH.z + 1).ToString();
                    C1.text = rH.x.ToString();
                    D1.text = (Random.Range(0, 150)).ToString();
                    correctA1 = true;
                }
                else if (num == 1)
                {
                    B1.text = rH.z.ToString();
                    A1.text = (rH.z + 1).ToString();
                    C1.text = rH.x.ToString();
                    D1.text = (Random.Range(0, 150)).ToString();
                    correctB1 = true;
                }
                else if (num == 2)
                {
                    C1.text = rH.z.ToString();
                    B1.text = (rH.z + 1).ToString();
                    A1.text = rH.x.ToString();
                    D1.text = (Random.Range(0, 150)).ToString();
                    correctC1 = true;
                }
                else if (num == 3)
                {
                    D1.text = rH.z.ToString();
                    B1.text = (rH.z + 1).ToString();
                    C1.text = rH.x.ToString();
                    A1.text = (Random.Range(0, 150)).ToString();
                    correctD1 = true;
                }
                else if (num == 4)
                {
                    A1.text = rH.z.ToString();
                    C1.text = (rH.z + 1).ToString();
                    B1.text = rH.x.ToString();
                    D1.text = (Random.Range(0, 150)).ToString();
                    correctA1 = true;
                }
                else if (num == 5)
                {
                    A1.text = rH.z.ToString();
                    D1.text = (rH.z + 1).ToString();
                    C1.text = rH.x.ToString();
                    B1.text = (Random.Range(0, 150)).ToString();
                    correctA1 = true;
                }
                else if (num == 6)
                {
                    A1.text = rH.z.ToString();
                    B1.text = (rH.z + 1).ToString();
                    D1.text = rH.x.ToString();
                    C1.text = (Random.Range(0, 150)).ToString();
                    correctA1 = true;
                }
                else if (num == 7)
                {
                    B1.text = rH.z.ToString();
                    C1.text = (rH.z + 1).ToString();
                    D1.text = rH.x.ToString();
                    A1.text = (Random.Range(0, 150)).ToString();
                    correctB1 = true;
                }
                else if (num == 8)
                {
                    C1.text = rH.z.ToString();
                    D1.text = (rH.z + 1).ToString();
                    A1.text = rH.x.ToString();
                    B1.text = (Random.Range(0, 150)).ToString();
                    correctC1 = true;
                }
                else if (num == 9)
                {
                    D1.text = rH.z.ToString();
                    A1.text = (rH.z + 1).ToString();
                    B1.text = rH.x.ToString();
                    C1.text = (Random.Range(0, 150)).ToString();
                    correctD1 = true;
                }
            }
            else
            {
                num = Random.Range(0, 10);
                if (num == 0)
                {
                    A1.text = rH.answer1;
                    B1.text = rH.answer2;
                    C1.text = rH.answer3;
                    D1.text = rH.answer4;
                    correctA1 = true;
                }
                else if (num == 1)
                {
                    B1.text = rH.answer1;
                    A1.text = rH.answer2;
                    C1.text = rH.answer3;
                    D1.text = rH.answer4;
                    correctB1 = true;
                }
                else if (num == 2)
                {
                    C1.text = rH.answer1;
                    B1.text = rH.answer2;
                    A1.text = rH.answer3;
                    D1.text = rH.answer4;
                    correctC1 = true;
                }
                else if (num == 3)
                {
                    D1.text = rH.answer1;
                    B1.text = rH.answer2;
                    C1.text = rH.answer3;
                    A1.text = rH.answer4;
                    correctD1 = true;
                }
                else if (num == 4)
                {
                    A1.text = rH.answer1;
                    C1.text = rH.answer2;
                    B1.text = rH.answer3;
                    D1.text = rH.answer4;
                    correctA1 = true;
                }
                else if (num == 5)
                {
                    A1.text = rH.answer1;
                    D1.text = rH.answer2;
                    C1.text = rH.answer3;
                    B1.text = rH.answer4;
                    correctA1 = true;
                }
                else if (num == 6)
                {
                    A1.text = rH.answer1;
                    B1.text = rH.answer2;
                    D1.text = rH.answer3;
                    C1.text = rH.answer4;
                    correctA1 = true;
                }
                else if (num == 7)
                {
                    B1.text = rH.answer1;
                    C1.text = rH.answer2;
                    D1.text = rH.answer3;
                    A1.text = rH.answer4;
                    correctB1 = true;
                }
                else if (num == 8)
                {
                    C1.text = rH.answer1;
                    D1.text = rH.answer2;
                    A1.text = rH.answer3;
                    B1.text = rH.answer4;
                    correctC1 = true;
                }
                else if (num == 9)
                {
                    D1.text = rH.answer1;
                    A1.text = rH.answer2;
                    B1.text = rH.answer3;
                    C1.text = rH.answer4;
                    correctD1 = true;
                }
            }
        }
        if (assignTwo)
        {
            if (mathQuestion)
            {
                num = Random.Range(0, 10);


                if (num == 0)
                {
                    A2.text = rH.z.ToString();
                    B2.text = (rH.z + 1).ToString();
                    C2.text = rH.x.ToString();
                    D2.text = (Random.Range(0, 150)).ToString();
                    correctA2 = true;
                }
                else if (num == 1)
                {
                    B2.text = rH.z.ToString();
                    A2.text = (rH.z + 1).ToString();
                    C2.text = rH.x.ToString();
                    D2.text = (Random.Range(0, 150)).ToString();
                    correctB2 = true;
                }
                else if (num == 2)
                {
                    C2.text = rH.z.ToString();
                    B2.text = (rH.z + 1).ToString();
                    A2.text = rH.x.ToString();
                    D2.text = (Random.Range(0, 150)).ToString();
                    correctC2 = true;
                }
                else if (num == 3)
                {
                    D2.text = rH.z.ToString();
                    B2.text = (rH.z + 1).ToString();
                    C2.text = rH.x.ToString();
                    A2.text = (Random.Range(0, 150)).ToString();
                    correctD2 = true;
                }
                else if (num == 4)
                {
                    A2.text = rH.z.ToString();
                    C2.text = (rH.z + 1).ToString();
                    B2.text = rH.x.ToString();
                    D2.text = (Random.Range(0, 150)).ToString();
                    correctA2 = true;
                }
                else if (num == 5)
                {
                    A2.text = rH.z.ToString();
                    D2.text = (rH.z + 1).ToString();
                    C2.text = rH.x.ToString();
                    B2.text = (Random.Range(0, 150)).ToString();
                    correctA2 = true;
                }
                else if (num == 6)
                {
                    A2.text = rH.z.ToString();
                    B2.text = (rH.z + 1).ToString();
                    D2.text = rH.x.ToString();
                    C2.text = (Random.Range(0, 150)).ToString();
                    correctA2 = true;
                }
                else if (num == 7)
                {
                    B2.text = rH.z.ToString();
                    C2.text = (rH.z + 1).ToString();
                    D2.text = rH.x.ToString();
                    A2.text = (Random.Range(0, 150)).ToString();
                    correctB2 = true;
                }
                else if (num == 8)
                {
                    C2.text = rH.z.ToString();
                    D2.text = (rH.z + 1).ToString();
                    A2.text = rH.x.ToString();
                    B2.text = (Random.Range(0, 150)).ToString();
                    correctC2 = true;
                }
                else if (num == 9)
                {
                    D2.text = rH.z.ToString();
                    A2.text = (rH.z + 1).ToString();
                    B2.text = rH.x.ToString();
                    C2.text = (Random.Range(0, 150)).ToString();
                    correctD2 = true;
                }
            }
            else
            {
                num = Random.Range(0, 10);
                if (num == 0)
                {
                    A2.text = rH.answer1;
                    B2.text = rH.answer2;
                    C2.text = rH.answer3;
                    D2.text = rH.answer4;
                    correctA2 = true;
                }
                else if (num == 1)
                {
                    B2.text = rH.answer1;
                    A2.text = rH.answer2;
                    C2.text = rH.answer3;
                    D2.text = rH.answer4;
                    correctB2 = true;
                }
                else if (num == 2)
                {
                    C2.text = rH.answer1;
                    B2.text = rH.answer2;
                    A2.text = rH.answer3;
                    D2.text = rH.answer4;
                    correctC2 = true;
                }
                else if (num == 3)
                {
                    D2.text = rH.answer1;
                    B2.text = rH.answer2;
                    C2.text = rH.answer3;
                    A2.text = rH.answer4;
                    correctD2 = true;
                }
                else if (num == 4)
                {
                    A2.text = rH.answer1;
                    C2.text = rH.answer2;
                    B2.text = rH.answer3;
                    D2.text = rH.answer4;
                    correctA2 = true;
                }
                else if (num == 5)
                {
                    A2.text = rH.answer1;
                    D2.text = rH.answer2;
                    C2.text = rH.answer3;
                    B2.text = rH.answer4;
                    correctA2 = true;
                }
                else if (num == 6)
                {
                    A2.text = rH.answer1;
                    B2.text = rH.answer2;
                    D2.text = rH.answer3;
                    C2.text = rH.answer4;
                    correctA2 = true;
                }
                else if (num == 7)
                {
                    B2.text = rH.answer1;
                    C2.text = rH.answer2;
                    D2.text = rH.answer3;
                    A2.text = rH.answer4;
                    correctB2 = true;
                }
                else if (num == 8)
                {
                    C2.text = rH.answer1;
                    D2.text = rH.answer2;
                    A2.text = rH.answer3;
                    B2.text = rH.answer4;
                    correctC2 = true;
                }
                else if (num == 9)
                {
                    D2.text = rH.answer1;
                    A2.text = rH.answer2;
                    B2.text = rH.answer3;
                    C2.text = rH.answer4;
                    correctD2 = true;
                }
            }
        }
    }

    void RandomCall()
    {
        num = Random.Range(0, 5);
        switch (num)
        {
            case 4:
                rH.MathAdd();
                mathQuestion = true;
                break;
            case 3:
                rH.MathSubtract();
                mathQuestion = true;
                break;
            case 2:
                rH.MathMultiply();
                mathQuestion = true;
                break;
            case 1:
                rH.MathDivide();
                mathQuestion = true;
                break;
            default:
                rH.GreekQuestion();
                mathQuestion = false;
                break;
        }
    }
}
