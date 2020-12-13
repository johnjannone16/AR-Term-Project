using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightInstantiate : MonoBehaviour
{
    public GameObject right90;
    public GameObject parentTransfer;
    public GameObject rightParent;
    public bool visible;

    public void instantiateRight()
    {

        if (visible == true)
        {
            
            right90.transform.parent = parentTransfer.transform;            
            var obj = Instantiate(right90) as GameObject;
            obj.transform.parent = rightParent.transform;
            obj.transform.localPosition = new Vector3(0.00281f, 0.00205f, 0.00141f);
            obj.transform.localRotation = Quaternion.Euler(-90f, 0f, 0f);
            obj.transform.localScale = new Vector3(0.4317433f, 0.4317433f, 0.4317433f);
            right90 = obj;
        }
    }

    public void setVisible()
    {
        visible = !visible;
    }
}
