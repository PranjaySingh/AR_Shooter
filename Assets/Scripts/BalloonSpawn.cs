using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawn : MonoBehaviour
{
    public GameObject[] balloons;

    [SerializeField] Camera arCamera;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(2);

        Vector3 screenPosition = arCamera.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width),
                                                                         Random.Range(0, Screen.height),
                                                                         Random.Range(( arCamera.farClipPlane / 4), (arCamera.farClipPlane / 2))));

        
            Instantiate(balloons[Random.Range(0,3)], screenPosition, Quaternion.identity);
        

        StartCoroutine(StartSpawning());
    }

}





//Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), Camera.main.farClipPlane / 2));