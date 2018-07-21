using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEngine : MonoBehaviour {

	public Transform wall;
	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	private float speed;
	void Start()
	{
		speed = Random.Range(140f,160f);
		GameObject wall_gobj = GameObject.Find("Wall");
		wall = wall_gobj.GetComponent<Transform>();
	}
	void Update () {
		transform.position = Vector2.MoveTowards(transform.position,new Vector2(350,transform.position.y),speed*Time.deltaTime);
	}
	void OnCollisionEnter2D(Collision2D other) {
		Debug.Log(other);
		if(other.gameObject.tag == "Player"){
			Debug.Log("gege");
		}
	}
}
