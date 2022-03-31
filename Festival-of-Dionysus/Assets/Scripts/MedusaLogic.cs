using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedusaLogic : MonoBehaviour
{
    [SerializeField]
    private float time = 0;
    [SerializeField]
    private bool freeze = false;

    void Start()
    {
        //Makes Dusa look left and staarts initial clock
        time = Random.Range(5.00f, 15.00f);
        this.GetComponent<RectTransform>().Rotate(new Vector3(0f, 0f, 180f));
    }

    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0 && !freeze) 
        {
            //Makes Dusa look right and restarts clock
            freeze = true;
            time = Random.RandomRange(2.00f, 5.00f);
            this.GetComponent<RectTransform>().Rotate(new Vector3(0f, 0f, 180f));
        }
        else if (time <= 0 && freeze)
        {
            //Makes Dusa look left and restarts clock
            freeze = false;
            time = Random.RandomRange(5.00f, 10.00f);
            this.GetComponent<RectTransform>().Rotate(new Vector3(0f, 0f, 180f));
        }
    }

    public void SetFreeze(bool B)
    {
        freeze = B;
    }

    public bool GetFreeze() 
    {
        return freeze;
    }
}
