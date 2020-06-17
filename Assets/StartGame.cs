using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(AudioSource))]
public class StartGame : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audioSource;

    public GameObject Fade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("SSS");
            AudioSource.PlayClipAtPoint(impact, transform.position);
            Fade.SetActive(true);
            StartCoroutine(Co_WaitForSeconds(3f));

        }
    }
    private IEnumerator Co_WaitForSeconds(float value)
    {
        
        yield return new WaitForSeconds(value);
        SceneManager.LoadScene("BASML_Demo_Scene 1");
    }
}
