using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnTriggerEnter2D is called when two colliders intersect and gameobject with this script has a IsTrigger flag ticked
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check if collision object is the Player
        if (collision != null && collision.gameObject.name == "Player")
        {
            //Increase score
            GameState.Score++;

            //Tell CoinSpawner it should spawn a new coin
            var coinSpawner = GameObject.FindAnyObjectByType<CoinSpawner>();
            coinSpawner.ShouldSpawnCoin = true;

            //Remove this coin from the game
            Destroy(gameObject);
        }
    }
}
