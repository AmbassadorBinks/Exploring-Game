using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupSpawn : MonoBehaviour
{
    public GameObject pickup;
    public Vector3 spawnValues;
    public int pickupCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    

    private GameObject[] getCount;
    

    void Start()
    {
        StartCoroutine(SpawnWaves());
        pickupCount = 1;
    }



    IEnumerator SpawnWaves()
    {
        while (pickupCount < 5)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, Random.Range(-spawnValues.z, spawnValues.z));
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(pickup, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(spawnWait);

            getCount = GameObject.FindGameObjectsWithTag("Pickup");
            pickupCount = getCount.Length;

            GameObject Player = GameObject.Find("Player");
            PickingUp pickingUp = Player.GetComponent<PickingUp>();
            
            if (pickingUp.IsDestroyed == true)
            {
                
                pickupCount -= 1;
            }
        }
        
        
    }        
}