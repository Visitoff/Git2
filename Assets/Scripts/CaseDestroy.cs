
using UnityEngine;
using System.Collections;

public class CaseDestroy : MonoBehaviour
    
{
    public GameObject Other;
    void Start()
    {
        
    }

 
        void Update()
    
        {   if (Input.GetKey(KeyCode.Space))
        {
            DestroyImmediate(Other, true);
        }
        
    }
}

