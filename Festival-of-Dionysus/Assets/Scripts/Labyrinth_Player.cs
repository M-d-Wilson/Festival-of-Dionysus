using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labyrinth_Player : MonoBehaviour
{
    [SerializeField]
    private int speed;
    [SerializeField]
    private Vector3 StartPos;
    private Rigidbody2D rb;
    private RectTransform UIplace;

    private void Awake()
    {
        //assigns Rigidbody
        rb = GetComponent<Rigidbody2D>();
        UIplace = GetComponent<RectTransform>();
    }

    private void FixedUpdate()
    {
        float x = UIplace.position.x;
        float y = UIplace.position.y;
        float z = UIplace.position.z;
        float newX = 0;
        float newY = 0;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            newX = speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            newX = speed * Time.deltaTime * -1;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            newY = speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            newY = speed * Time.deltaTime * -1;
        }

        if ((newX > 0 || newX < 0) || (newY > 0 || newY < 0))
            rb.AddForce(new Vector2(newX, newY));
        else
            rb.Sleep();
    }
}
