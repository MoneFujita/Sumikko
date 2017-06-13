using UnityEngine;
using System.Collections;

public class ChangeScript : MonoBehaviour {
	private Vector3 pos;

	// Use this for initialization
	void Start () {
		 pos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		this.transform.position = col.gameObject.GetComponent<ChangeScript> ().pos;
		StartCoroutine (ChangePos(col));
	}

	public Vector3 Pos{
		get{ 
			return this.pos;
		}
		private set{ 
			this.pos = value; 
		}
	}

	private IEnumerator ChangePos(Collider col){
		yield return new WaitForSeconds (0.1f); 
		pos = col.gameObject.GetComponent<ChangeScript> ().pos;
	}
}
