using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapTest : MonoBehaviour
{

    public GameObject parentObject;
    public GameObject snapArea;

    //This is the moving wall
    void OnTriggerEnter(Collider other)
    {
        snapArea.transform.parent.position = other.transform.position + (snapArea.transform.parent.position - snapArea.transform.position);
    }

    private void OnTriggerExit(Collider other)
    {
        this.transform.parent.position = parentObject.transform.position;
    }
}