using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Enemy Spawn;
    public GameObject[] Enemy = new GameObject[6];
    public float Speed;
    public float DeltaSpeed;
    public float MaxSpeed;
    public float TimeSpawn;
    public float DeltaTimeSpawn;
    public float MinTimeSpawn;

    void Start()
    {
        InvokeRepeating( "SpawnEnemy", 1, TimeSpawn );
    }

    private void SpawnEnemy() 
    {
        int random = Random.Range(0, 100);

        if( random <= 10 ) Spawn = Instantiate( Enemy[0], transform.position, Quaternion.identity ).GetComponent<Enemy>();
        else if( random <= 20 ) Spawn = Instantiate( Enemy[1], transform.position, Quaternion.identity ).GetComponent<Enemy>();
        else if( random <= 30 ) Spawn = Instantiate( Enemy[2], transform.position, Quaternion.identity ).GetComponent<Enemy>();
        else if( random <= 50 ) Spawn = Instantiate( Enemy[3], transform.position, Quaternion.identity ).GetComponent<Enemy>();
        else if( random <= 75 ) Spawn = Instantiate( Enemy[4], transform.position, Quaternion.identity ).GetComponent<Enemy>();
        else Spawn = Instantiate( Enemy[5], transform.position, Quaternion.identity ).GetComponent<Enemy>();

        if( Speed < MaxSpeed ) Speed += DeltaSpeed;
        if( TimeSpawn > MinTimeSpawn ) TimeSpawn -= DeltaTimeSpawn;
        Spawn.setSpeed( Speed );
    }
}
