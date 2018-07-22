using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCastScript : MonoBehaviour 
{
	[SerializeField]
	Camera camera;
	public Text scoreText;
	public int score;

	public RandomInstance randomInstance;
	void Start()
	{
		camera = GetComponent<Camera>();
	}
	void Update()
	{	
		if( Input.touchCount >0 )
		{
			Debug.Log(Input.GetTouch(0).position);
		}
		if (Input.GetMouseButtonDown(0))
		{
        	Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(ray.origin,ray.direction);
			if(hit!=null)	
			{
				if(hit.collider.gameObject.tag == "Enemy")
				{
				Debug.DrawLine(ray.origin,hit.point);
				Destroy(hit.transform.gameObject);
				score +=2;
				scoreText.text = score.ToString();
				
			}
		}
	}
}
}
