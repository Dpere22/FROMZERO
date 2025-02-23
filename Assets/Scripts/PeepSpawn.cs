using System.Collections;
using UnityEngine;

public class PeepSpawn : MonoBehaviour
{
    [SerializeField] private GameObject Spawner, Peep;
    [SerializeField] private float SpawnSpeed;
    float X;
    float Y;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        X = Spawner.transform.position.x;
        Y = Spawner.transform.position.y;
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(SpawnSpeed);
            Instantiate(Peep, new Vector3(X, Y, 0), Quaternion.identity);
        }
    }
}
