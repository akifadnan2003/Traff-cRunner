using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Spawner : MonoBehaviour
{
    public GameObject coinPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoinSpawnner());
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void CoinsSpawn(){
        float rand=Random.Range(-1.8f,1.8f);
        Instantiate(coinPrefab,new Vector3(rand,transform.position.y,transform.position.z),Quaternion.identity);
    }

    IEnumerator CoinSpawnner(){
        while(true){
            yield return new WaitForSeconds(5f);
            CoinsSpawn();
        
    }
}
}
