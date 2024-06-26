using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    private float timer;
    private GameObject player;
    public float disLimite;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);

        Debug.Log(distance);

        if (distance < disLimite)
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {
                timer = 0;
                Shoot(); 
            }
        }
    }

    void Shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
