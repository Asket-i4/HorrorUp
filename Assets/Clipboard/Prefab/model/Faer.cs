using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faer : MonoBehaviour
{
	public Transform bullet;
	public Transform neew;
	public int BulletForce = 5000;
	public int Magaz = 30;
	public int CountMagazin = 3;
	public AudioClip Fire;
	public AudioClip Reload;
	bool chek = true;
	bool chek2 = true;
	float a = 2;
	Vector3 vec;


	//void Start()
	//{
	//	InvokeRepeating("RunTimer", 10, 00001);
	//}

	//void RunTimer()
	//{
	//	Debug.Log(12);

	//} Тут надо побаловаться с InvokeRepeating("RunTimer", 10, 00001); с переменными, это таймер мощешь использовать для перезорядки шокера


	void Update()
	{
		/// Отвечает за саму стрельбу сюда можешт докинуть стар таймера на перезорядку
		if (chek)
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
				chek = false;
				StartCoroutine(StopFaer());
			}
		}

		// Это смена самой боторейки или же обоймы тут как хочешь можешь отобразить смену батарейки
		if (Input.GetKeyDown(KeyCode.R) & CountMagazin > 0 & chek2)
		{
			if (CountMagazin > 0)
				Magaz = 3;
			CountMagazin--;
			chek2 = false;
			StartCoroutine(RePover()); // Это карутина мощешь взять для задержки переключения рук и шокера

		}
	}

	// Это карутина мощешь взять для задержки переключения рук и шокера
	IEnumerator RePover()
	{
		yield return new WaitForSeconds(4);// Время ожидания в сек
		chek2 = true;
	}
	// Это карутина мощешь взять для задержки переключения рук и шокера
	IEnumerator StopFaer()
	{
		yield return new WaitForSeconds(7);// Время ожидания в сек
		chek = true;
	}
}

