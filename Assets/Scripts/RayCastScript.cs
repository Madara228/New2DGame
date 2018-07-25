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
		#if UNITY_ANDROID
		Debug.Log("ANDROID");
		if( Input.touchCount >0 )
		{
			Debug.Log(Input.GetTouch(0).position);
			Ray ray = camera.ScreenPointToRay(Input.GetTouch(0).position);
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
		#endif
		#if UNITY_EDITOR
		Debug.Log("Unity");
		if (Input.GetMouseButtonDown(0))
		{
        	Ray ray_pc = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit_pc = Physics2D.Raycast(ray_pc.origin,ray_pc.direction);
			if(hit_pc!=null)	
			{
				if(hit_pc.collider.gameObject.tag == "Enemy")
				{
					Debug.DrawLine(ray_pc.origin,hit_pc.point, new Color(198,29,38,1));
					Destroy(hit_pc.transform.gameObject);
					score +=2;
					scoreText.text = score.ToString();
				}
			}
		}
	}
		#endif
}

