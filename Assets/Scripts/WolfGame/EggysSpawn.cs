using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class EggysSpawn : MonoBehaviour
{
    public static EggysSpawn instance = null;
    
    [SerializeField] private GameObject _eggyPrefab;
    [SerializeField] private Transform[] _spawnPosition;
    
    private void Start()
    {
        instance = this;
        StartCoroutine(EggySpawn());
    }
    
    public IEnumerator EggySpawn()
    {
        while (true)
        {
            int randPosition = Random.Range(0, _spawnPosition.Length - 1);
            Instantiate(_eggyPrefab, _spawnPosition[randPosition].position, Quaternion.identity);
            
            yield return new WaitForSeconds(5f);
        }
    }
}
