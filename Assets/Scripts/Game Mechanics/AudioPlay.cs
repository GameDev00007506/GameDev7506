using System;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public static AudioPlay _instance;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(_instance);
            return;
        }
        
        Destroy(gameObject);
        
        
    }
}
