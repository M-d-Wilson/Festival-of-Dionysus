using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labyrinth_Enemy : MonoBehaviour
{
    [SerializeField]
    private RectTransform UIplace;
    [SerializeField]
    private Vector2 StartPos;

    private void Awake()
    {
        //assigns Rigidbody
        UIplace = GetComponent<RectTransform>();
        UIplace.localPosition = StartPos;
    }

    public void ResetPos()
    {
        UIplace.localPosition = StartPos;
    }
}
