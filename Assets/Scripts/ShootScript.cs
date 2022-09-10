using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;

    public Text scoreText;

    public AudioClip shoot;
    public AudioClip pop
        ;

    AudioSource audioSource;


    int score = 0;

    private void Start()
    {
        scoreText.text = score.ToString();
        audioSource = GetComponent<AudioSource>();
    }

    public void Shoot()
    {
        RaycastHit hit;

        audioSource.clip = shoot;

        audioSource.Play();

        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if(hit.transform.tag == "Balloon")
            {
                score++;
                scoreText.text = score.ToString();
                
                Destroy(hit.transform.gameObject, 0.15f);
                audioSource.clip = pop;
                audioSource.PlayDelayed(0.15f);
            }
        }
    }
}
