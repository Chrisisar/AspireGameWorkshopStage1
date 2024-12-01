using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject CoinPrefab;
    public bool ShouldSpawnCoin = true;
    public List<GameObject> Platforms = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Create a single coin at the start of the game
        GameObject go = Instantiate(CoinPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        if (ShouldSpawnCoin)
        {
            ShouldSpawnCoin = false;

            //Create new object from prefab
            GameObject go = Instantiate(CoinPrefab);

            //Select a random platform and set new coin's poisition right above it
            var selectedPlatform = Platforms[Random.Range(0, Platforms.Count)];
            Debug.Log("Coin Spawned");
            go.transform.position = selectedPlatform.transform.position + new Vector3(0, 1, 0);
        }
    }
}
