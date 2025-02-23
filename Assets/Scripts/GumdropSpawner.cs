using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GumdropSpawner : MonoBehaviour
{
    [SerializeField] private GameObject StartPoint, EndPoint;
    [SerializeField] private float MaxSpawnSpeed;
    [SerializeField] private List<GameObject> Gumdrops;

    [SerializeField] private Transform player;
    [SerializeField] private Transform spawnPoint;

    [SerializeField] private float offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Spawn());
    }

    void Update()
    {
        spawnPoint.position = new Vector3(0f, player.position.y + offset, 0f);
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0, MaxSpawnSpeed));
            SpawnGumdrop();
        }
    }
    private void SpawnGumdrop()
    {
        float random = Random.Range(StartPoint.transform.position.x, EndPoint.transform.position.x);
        GameObject choice = Gumdrops[Random.Range(0, Gumdrops.Count)];
        Instantiate(choice, new Vector3(random, StartPoint.transform.position.y, 0), Quaternion.identity);
    }
}
