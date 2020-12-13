using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    public GameObject Object2Copy;
    public GameObject Object2Parent;

    public void CreateObjectInstance()
    {
        if (Object2Copy.activeSelf)
        {
            GameObject instance = Instantiate(Object2Copy, Object2Copy.transform.position, Object2Copy.transform.rotation) as GameObject;

            instance.transform.parent = Object2Parent.transform;
            instance.name = "NewInstance";
        }
    }
}
