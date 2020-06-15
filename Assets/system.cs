using UnityEngine;
using System.Collections;

public class system : MonoBehaviour {
	
	public float speed = 5.0f;
	
	public CharacterController Controller;

	public Vector3 moveDirection = Vector3.zero;

	// Use this for initialization
	void Start () {
		Controller = gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		moveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
		
		Controller.Move(moveDirection * Time.deltaTime);
	}
}
