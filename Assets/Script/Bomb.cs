using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    float darbeGucu;
    

    GameObject gameControl;
    void Start()
    {
        darbeGucu = 21;
        gameControl = GameObject.FindWithTag("GameControl");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("OtherBox"))
        {
            collision.gameObject.GetComponent<OtherBox>().DarbeAl(darbeGucu);

            gameControl.GetComponent<GameControl>().VoiceAndEffect(0,collision.gameObject);

            Destroy(gameObject);

         
        }

        if (collision.gameObject.CompareTag("PlayerOneTower"))
        {
            gameControl.GetComponent<GameControl>().VoiceAndEffect(0, collision.gameObject);
            gameControl.GetComponent<GameControl>().DarbeVur(0, darbeGucu);

            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("PlayerTwoTower"))
        {
            gameControl.GetComponent<GameControl>().VoiceAndEffect(1, collision.gameObject);
            gameControl.GetComponent<GameControl>().DarbeVur(1,darbeGucu);

            Destroy(gameObject);
        }

        
    }
}
