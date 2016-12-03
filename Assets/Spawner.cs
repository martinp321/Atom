using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{

    public float timeBetweenSpawns;
    public float spawnDistance;
    public Atom[] atomPrefabs;
    float timeSinceLastSpawn;

    private void FixedUpdate()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= timeBetweenSpawns)
        {
            timeSinceLastSpawn -= timeBetweenSpawns;
            Spawn();

        }
    }

    void Spawn()
    {
        Atom prefab = atomPrefabs[Random.Range(0, atomPrefabs.Length)];
        Atom spawn = Instantiate<Atom>(prefab);
        spawn.transform.localPosition = Random.onUnitSphere * spawnDistance;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
