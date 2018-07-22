using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CollisionDetector : MonoBehaviour {
	public Text health_text;
	public GameObject lose_txt;
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
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
