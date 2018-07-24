using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameControllerScipt : MonoBehaviour {

	public Button btn;
	void Start()
	{
		btn = btn.GetComponent<Button>();
		btn.onClick.AddListener(reload);
	}

	public void reload(){
		Debug.Log("WORKKKK");
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
