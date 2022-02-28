using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneTop : MonoBehaviour
{

    public GameObject bomb;
    public GameObject topExitPoint;
    public ParticleSystem topAtisEffect;
    public AudioSource TopAtisSesi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(topAtisEffect, topExitPoint.transform.position, topExitPoint.transform.rotation);
            TopAtisSesi.Play();
            GameObject bombObject = Instantiate(bomb,topExitPoint.transform.position,topExitPoint.transform.rotation);
            Rigidbody2D rb = bombObject.GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(3f,0f)*10f,ForceMode2D.Impulse);
            
            //topAtisEffect.Play();
        }

    }
}
