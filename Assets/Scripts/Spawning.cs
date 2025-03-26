using UnityEngine;

public class Spawning : MonoBehaviour{

    public GameObject missle;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;

    
    // Update is called once per frame
    void Update(){

        if (Time.time > spawnTime) {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }
    void Spawn() {
        float spawnX = Random.Range(minX, maxX);
        float spawnY = Random.Range(minY, maxY);
        Instantiate(missle, transform.position + new Vector3(spawnX, spawnY,0), transform.rotation);

    }
}
