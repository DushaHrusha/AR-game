using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnPointer;
    public GameObject[] ball;

    public void StartGame()
    {
        StartCoroutine(StartSpawnig());
    }

    public void StopGame()
    {
        StopCoroutine(StartSpawnig());
    }
    IEnumerator StartSpawnig()
    {
        yield return new WaitForSeconds(4f);
        for (int i = 0; i < 3; i++)
        {
            Instantiate(ball[i], spawnPointer[i].position, Quaternion.identity);
        }
        StartCoroutine(StartSpawnig());
    }
}
