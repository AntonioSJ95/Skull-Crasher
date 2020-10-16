using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] spawnPoint; //Puntos donde se hara el spawn
    public GameObject[] ballons; //Gameobject de globos
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Startspawn());
    }

  IEnumerator Startspawn() //Numerador que hara spawnear los globos
  {
      yield return new WaitForSeconds(4);

      for (int i = 0; i < 3; i++)
      {
          Instantiate(ballons[i], spawnPoint[i].position, Quaternion.identity);
      }

      StartCoroutine(Startspawn());
  }
}
