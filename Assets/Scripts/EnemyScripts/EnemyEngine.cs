using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEngine : MonoBehaviour {

	public Transform wall;
	private float speed;
	private Rigidbody2D rb;
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		speed = Random.Range(140f,150f);
		GameObject wall_gobj = GameObject.Find("Wall");
		wall = wall_gobj.GetComponent<Transform>();
	}
	void Update () {
	//	rb.AddForce(wall.position.normalized*speed);
		transform.position = Vector2.MoveTowards(transform.position,new Vector2(350,transform.position.y),speed*Time.deltaTime);
	}
}
