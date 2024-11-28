using UnityEngine;

public class GroundCheckBehaviour : MonoBehaviour
{
    public GameObject PlayerObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(0,-0.3f,0) + PlayerObject.transform.position;
    }
}
