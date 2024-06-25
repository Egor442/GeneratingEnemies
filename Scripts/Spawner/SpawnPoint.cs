using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Vector3 GenerateRandomDirection()
    {
        Vector3 direction;
        
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        return direction;
    }
}