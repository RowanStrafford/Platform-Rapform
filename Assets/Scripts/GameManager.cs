using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public GameObject platform;
    float spawnSeconds = 3f;

    void Start()
    {
        InvokeRepeating("SpawnPlatform", 0, spawnSeconds);
    }

    void Update()
    {

    }

    void SpawnPlatform()
    {
        Instantiate(platform, new Vector3(Random.Range(-3.5f, 3.5f), 7.5f, 0), Quaternion.identity);
    }
}
