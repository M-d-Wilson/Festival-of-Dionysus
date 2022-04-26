using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Graphic customPanel;

    void OnTriggerEnter(Collider col)
	{
		if(col.CompareTag("Player"))
		{
			customPanel.enabled = true;
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.CompareTag("Player"))
		{
			customPanel.enabled = false;
		}
	}

}
