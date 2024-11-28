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
        GameObject go = Instantiate(CoinPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        if (ShouldSpawnCoin)
        {
            ShouldSpawnCoin = false;
            GameObject go = Instantiate(CoinPrefab);
            var selectedPlatform = Platforms[Random.Range(0, Platforms.Count)];
            Debug.Log("Coin Spawned");
            go.transform.position = selectedPlatform.transform.position + new Vector3(0, 1, 0);
        }
    }
}
