using UnityEngine;
using System.Collections;

public class ChangeScript : MonoBehaviour {
	Vector3 pos;

	// Use this for initialization
	void Start () {
		 pos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "sumikko") {
			GameObject.Find ("sumikko").transform.position = pos;
		}
	}
}
