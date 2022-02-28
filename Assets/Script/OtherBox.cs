using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OtherBox : MonoBehaviour
{
    float saglik = 100;
    public Image healtBar;
    public GameObject HealtCanvas;

    GameObject gameControl;
    // Start is called before the first frame update
    void Start()
    {
        gameControl = GameObject.FindGameObjectWithTag("GameControl");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DarbeAl(float darbeGucu)
    {
        saglik -= darbeGucu;

        healtBar.fillAmount = saglik / 100; //fill amount 0.10

        if (saglik<0)
        {
            gameControl.GetComponent<GameControl>().VoiceAndEffect(1,gameObject);
            Destroy(gameObject);
        }
        else
        {
            StartCoroutine(CanvasCikar());
        }

        
    }

    IEnumerator CanvasCikar()
    {
        if (!HealtCanvas.activeInHierarchy)
        {
            HealtCanvas.SetActive (true);
            yield return new WaitForSeconds(1);
            HealtCanvas.SetActive(false);
        }
    }
}
