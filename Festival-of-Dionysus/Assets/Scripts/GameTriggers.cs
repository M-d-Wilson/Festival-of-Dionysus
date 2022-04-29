using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTriggers : MonoBehaviour
{
	[SerializeField]
	private GameObject Game1, LabrinthPlayer, Game2, Game3, DefencePlayer;
	
	void Start()
	{

		Time.timeScale = 1;
		Game2.SetActive(false);
		Game1.SetActive(false);
		Game3.SetActive(false);
	}

	
	void OnTriggerEnter(Collider col)
		{
		if (col.tag == "Medusa")
		{
			//LabrinthPlayer.SetActive(true);
			Debug.Log("touching");
			Game2.SetActive(true);
		}
		else if (col.tag == "Defend")
		{
			//LabrinthPlayer.SetActive(true);
			Debug.Log("touching");
			Game3.SetActive(true);
		}
		else if (col.tag == "Labrinth")
		{
			//LabrinthPlayer.SetActive(true);
			Debug.Log("touching");
			Game1.SetActive(true);
		} else if (col.tag =="LevelSelect")
			{
			SceneManager.LoadScene(1);

			}

		else
		{
			Game1.SetActive(false);
			Game2.SetActive(false);
			Game3.SetActive(false);
		}
		}
}
