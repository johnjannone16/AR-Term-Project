using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPositionFind : MonoBehaviour
{
    private Vector3 position1;
    private Vector3 position2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position1 = GameObject.Find("ImageTarget_1").transform.position;
        Debug.Log("position of the object tagged ImageTarget1 is: " + position1);

        position2 = GameObject.Find("ImageTarget_2").transform.position;
        Debug.Log("position of the object named ImageTarget_2 is" + position2);

        float dist = Vector3.Distance(position1, position2);
        Debug.Log("distance between ImageTarget_1 and ImageTarget_2 objects is: " + dist);
    }
}
