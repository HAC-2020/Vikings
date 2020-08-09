using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class SpawnHandler : MonoBehaviour
{
    public Action destroyObject;
    
    public void DestroyObject()
    {
        destroyObject?.Invoke();
    }
    
}
