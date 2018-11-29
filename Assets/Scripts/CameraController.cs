using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


	public GameObject Player1;
	private Vector3 offset;
	//offset = position(camera) - position(player)

	// Use this for initialization
	void Start () 
	{
		offset = transform.position - Player1.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		//LateUpdate() runs after all objects are done with Update in a frame
		// This ensures that camera takes image after all objects are set
		transform.position = Player1.transform.position + offset;
	}
}
