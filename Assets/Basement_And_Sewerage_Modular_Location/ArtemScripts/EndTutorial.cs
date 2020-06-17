using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndTutorial : MonoBehaviour
{
    public GameObject finishPanal;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider otehr)
    {
        if (otehr.gameObject.tag == "player")
        {
            Debug.Log("Финиш");
            finishPanal.SetActive(true);
            StartCoroutine(Co_WaitForSeconds(3f));
            Debug.Log("запуск очереди");
        }
    }
    private IEnumerator Co_WaitForSeconds(float value)
    {

        yield return new WaitForSeconds(value);
        SceneManager.LoadScene("Menu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
