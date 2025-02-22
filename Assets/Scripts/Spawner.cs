using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject StartPoint, EndPoint;
    [SerializeField] private float SpawnSpeed;
    [SerializeField] private List<GameObject> Gumdrops;
    float StartX;
    float EndX;
    float Y;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartX = StartPoint.transform.position.x;
        EndX = EndPoint.transform.position.x;
        Y = StartPoint.transform.position.y;
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(SpawnSpeed);
            SpawnGumdrop();
        }
    }
    private void SpawnGumdrop()
    {
        float random = Random.Range(StartX, EndX);
        GameObject choice = Gumdrops[Random.Range(0, Gumdrops.Count)];
        Instantiate(choice, new Vector3(random, Y, 0), Quaternion.identity);
    }
}
