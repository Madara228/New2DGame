using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomInstance : MonoBehaviour {
	public Vector3 size,position;
	public float n = 1f;
	public GameObject enemPref;
	void Start () {
		StartCoroutine(spawner());
	}
	

	private void OnDrawGizmosSelected() {
		Gizmos.color = new Color(1,9,9,9f);
		Gizmos.DrawCube(position,size);
	}

	IEnumerator spawner(){
		while(true){
		yield return new WaitForSeconds(n);
		Vector3 pos = new Vector3(Random.Range(-size.x/2,size.x/2),Random.Range(-size.y/2,size.y/2),size.z);
		Instantiate(enemPref,pos,Quaternion.identity);
		}
	}
	
}
