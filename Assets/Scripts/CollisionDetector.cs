using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CollisionDetector : MonoBehaviour {
	public Text score_text_final;
	public Text health_text;
	public GameObject lose_txt;
	public Camera camera;
	public RayCastScript rayCastScript;
	public GameObject win_panel;
	private int health = 5;
	void Start(){
		health_text.text = health.ToString();
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log("WORK!");
		Debug.Log(other);
		if(other.gameObject.tag == "Enemy"){
			Destroy(other.gameObject);
			health -=1;
			health_text.text = health.ToString();
			check();
		}
	}
	void check(){
		if(health <= 0){
			StartCoroutine(checker());
		}
	}
	private IEnumerator checker(){
		lose_txt.SetActive(true);
		yield return new WaitForSeconds(3f);
		openMenu();
	}

	private void openMenu(){
		score_text_final.text = "Your score " + rayCastScript.score.ToString();
		win_panel.SetActive(true);
		camera.transform.position = new Vector3(1000,1000,1000);
	}

	public void reload(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	
}
