using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GameOver : MonoBehaviour {

	void Update ()
	{
		if (Input.GetButtonDown("Jump"))
		{
			GameManager.instance.Restart();
		}

		
		GetComponent<RectTransform>().localScale = Vector3.one * Planet.Size;
	}

	public void Menu ()
	{
		SceneManager.LoadScene("Menu");
	}

}
