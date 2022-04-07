using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomQuestion : MonoBehaviour
{
    public int x, y, z, temp/*, num*/;
    public string question, answer1, answer2, answer3, answer4;/*, answerA, answerB, answerC, answerD;*/
    //public bool correctA, correctB, correctC, correctD, questionAsked;
    //RangeInt rnd = new RangeInt();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void MathAdd()
    {
        x = Random.Range(0, 51);
        y = Random.Range(0, 51);
        Debug.Log(x + " + " + y + " = ");
        z = x + y;
        Debug.Log(z);
        question = "What is " + x + " + " + y;

    }
    public void MathSubtract()
    {
        x = Random.Range(0, 51);
        y = Random.Range(0, 51);
        Debug.Log(x + " - " + y + " = ");
        if (x - y > 0)
        {
            z = x - y;
        }
        else if (x - y < 0)
        {
            temp = x;
            x = y;
            y = temp;
            z = x - y;

        }
        question = "What is " + x + " - " + y;
        Debug.Log(z);

    }
    public void MathMultiply()
    {
        x = Random.Range(0, 10);
        y = Random.Range(0, 10);
        z = x * y;
        Debug.Log(x + " x " + y + " = ");
        Debug.Log(z);
        question = "What is " + x + " x " + y;
    }

    public void MathDivide()
    {
        x = Random.Range(0, 46);
        y = Random.Range(0, 11);
        z = x / y;
        if (z == 0 && x != y)
        {
            MathDivide();
            Debug.Log("rerun");
        }
        Debug.Log(x + " / " + y + " = ");
        Debug.Log(z);
        question = "What is " + x + " / " + y;
    }

    public void GreekQuestion()
    {
        z = Random.Range(0, 6);
        switch (z)
        {
            case 5:
                question = "Who was the god of the skies?";
                answer1 = "Zeus";
                answer2 = "Hera";
                answer3 = "Hades";
                answer4 = "Ms.Archuleta";
                break;
            case 4:
                question = "Who was the god of the underworld?";
                answer1 = "Hades";
                answer2 = "Zeus";
                answer3 = "Poseidon";
                answer4 = "Apollo";
                break;
            case 3:
                question = "Who is the god of the sun?";
                answer1 = "Apollo";
                answer2 = "Artemis";
                answer3 = "Aphrodite";
                answer4 = "Hephaestus";
                break;
            default:
                question = "Who is the son of Zeus?";
                answer1 = "Heracles";
                answer2 = "Hunkules";
                answer3 = "Hercules";
                answer4 = "Harold";
                break;
        }
    }
}
