using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;

    public int Score;

    public Text scoreText;

    public void shoot() {
        RaycastHit hit;

        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit)) {
            if (hit.transform.name == "whiteSkull(Clone)") { //Esto es para especificar que va a pasar si el jugador "dispara" contra cierto game object del juego
                Destroy(hit.transform.gameObject);

                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
                AddScore();
            }else
            if (hit.transform.name == "blueSkull(Clone)") { //Esto es para especificar que va a pasar si el jugador "dispara" contra cierto game object del juego
                Destroy(hit.transform.gameObject);

                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
                AddScoreBlue();
            }


        }

        

        
    }

    void AddScore()
    {
        Score++;
        scoreText.text = Score.ToString();
    }

    void AddScoreBlue()
    {
        Score+=2;
        scoreText.text = Score.ToString();
    }
    
}
