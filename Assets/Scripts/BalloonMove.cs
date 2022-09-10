using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMove : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 2f);


        if (gameObject.transform.position.y > 30.0f)
        {
            Destroy(gameObject);
        }
    }
}
