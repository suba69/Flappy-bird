using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timeToSpawn, minYposition, maxYposition;
    public GameObject pipePrefab;
    private float timer;

    private void Start()
    {

    }

    private void Update()
    {
        if (timer <= 0)
        {
            timer = timeToSpawn;
            GameObject pipe = Instantiate(pipePrefab, transform.position, Quaternion.identity);
            float rand = Random.Range(minYposition, maxYposition);
            pipe.transform.position = new Vector3(pipe.transform.position.x, rand, 0);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
