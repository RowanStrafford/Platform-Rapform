using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public static int WIDTH = 10;
	public static int HEIGHT = 16;

	public GameObject platform;
	public GameObject player;
	public GameObject camera;


	public float spawnSeconds = 1f;

    void Start()
    {
        InvokeRepeating("SpawnPlatform", 0, spawnSeconds);
    }

    void Update()
    {
		float diff = player.transform.localPosition.y - camera.transform.localPosition.y;
		if (diff > 10|| diff< 10) {
			camera.transform.Translate(0, diff / 20, 0);
		}
    }

    void SpawnPlatform()
    {
        Instantiate(platform, new Vector3(Random.Range(-3.5f, 3.5f), player.transform.localPosition.y+20, 0), Quaternion.identity);
    }
}
