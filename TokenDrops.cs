using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenDrops : MonoBehaviour
{
    public GameObject token;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnToken()
    {
        Instantiate(token);
    }
}
