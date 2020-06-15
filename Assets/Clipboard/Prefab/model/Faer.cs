using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faer : MonoBehaviour
{
	public Transform bullet;
	public Transform neew;
	public int BulletForce = 5000;
	public int Magaz = 30;
	public AudioClip Fire;
	public AudioClip Reload;
	float a = 2;
	Vector3 vec;
	void Update()
	{
		if (Input.GetMouseButtonDown(0) & Magaz > 0)
		{
			Transform BulletInstance = (Transform)Instantiate(bullet, GameObject.Find("spawn").transform.position, Quaternion.identity);
			
			vec = new Vector3(transform.forward.x + 5, transform.forward.y, transform.forward.z);
			//(transform.forward.x + *-1) *
			BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * BulletForce);
			Magaz = Magaz - 1;
			GetComponent<AudioSource>().PlayOneShot(Fire);
			GetComponent<AudioSource>().PlayOneShot(Reload);

		}
		if (Input.GetKeyDown(KeyCode.R))
		{
			Magaz = 7;

		}
	}
}

