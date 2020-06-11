using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CheckRandom : MonoBehaviour
{
    public int attempt = 1000000000;

    void Start()
    {
        float[] checkNumber = new float[50];
        for (int i = 0; i < checkNumber.Length; i++)
        {
            checkNumber[i] = Random.value;
        }
        for (int b = 0; b < 4; b++)
        {
            for (int i = 0; i < attempt; i++)
            {
                for (int ii = 0; ii < checkNumber.Length && checkNumber[ii] == Random.value; i++)
                {
                    if (ii == 49)
                    {
                        print("есть");
                    }
                }
            }
        }
        print("Коней");
    }


}
//public class Building : MonoBehaviour
//{
//    public GameObject cube;

//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.Mouse1))
//        {
//            SpawnCube();
//        }
//        if (Input.GetKeyDown(KeyCode.Mouse0))
//        {
//            DestroyCube();
//        }
//    }
//    void DestroyCube()
//    {
//        Ray ray = transform.GetChild(0).GetComponent<Camera>().ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
//        RaycastHit hit;
//        if (Physics.Raycast(ray, out hit, 5f))
//        {
//            Destroy(hit.transform.gameObject);
//        }
//    }
//    void SpawnCube()
//    {
//        Ray ray = transform.GetChild(0).GetComponent<Camera>().ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
//        RaycastHit hit;
//        if (Physics.Raycast(ray, out hit, 5f))
//        {
//            Vector3 blockPos = hit.transform.position;
//            Vector3 hitPos = hit.point;
//            Vector3 plusPos = Vector3.zero;

//            float Xdistance = hitPos.x - blockPos.x;
//            float Ydistance = hitPos.y - blockPos.y;
//            float Zdistance = hitPos.z - blockPos.z;

//            if (Xdistance == 0.5f || Xdistance == -0.5f)
//            {
//                plusPos = new Vector3(Xdistance * 2, 0, 0);
//            }
//            else if (Ydistance == 0.5f || Ydistance == -0.5f)
//            {
//                plusPos = new Vector3(Ydistance * 2, 0, 0);
//            }
//            else if (Zdistance == 0.5f || Zdistance == -0.5f)
//            {
//                plusPos = new Vector3(Zdistance * 2, 0, 0);
//            }

//            Vector3 spawnPos = blockPos + plusPos;

//            Instantiate(cube, spawnPos, Quaternion.identity);
//        }
//    }
//}