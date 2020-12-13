using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftInstantiate : MonoBehaviour
{
    public GameObject left90;
    public GameObject parentTransfer;
    public GameObject leftParent;
    public bool visible;

    public void instantiateLeft()
    {

        if (visible == true)
        {
            left90.transform.parent = parentTransfer.transform;
            var obj = Instantiate(left90) as GameObject;
            obj.transform.parent = leftParent.transform;
            obj.transform.localPosition = new Vector3(0.00281f, 0.00205f, 0.00141f);
            obj.transform.localRotation = Quaternion.Euler(-90f, 0f, 0f);
            obj.transform.localScale = new Vector3(0.4317433f, 0.4317433f, 0.4317433f);
            left90 = obj;
        }
    }

    public void setVisible()
    {
        visible = !visible;
    }

}
