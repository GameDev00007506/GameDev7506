using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;

    public List<GameObject> PooledObjects = new List<GameObject>();
    
    [SerializeField] private int _amountToPool = 20;

    [SerializeField] private GameObject _arrowPrefab;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        for (int i = 0; i < _amountToPool; i++)
        {
            GameObject obj = Instantiate(_arrowPrefab, this.gameObject.transform);
            obj.SetActive(false);
            PooledObjects.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < PooledObjects.Count; i++)
        {
            if (!PooledObjects[i].activeInHierarchy)
            {
                return PooledObjects[i];
            }
        }
        return null;
    }
}
