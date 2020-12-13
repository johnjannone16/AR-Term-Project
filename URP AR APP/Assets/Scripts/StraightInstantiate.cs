using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightInstantiate : MonoBehaviour
{
    public GameObject straight;
    public GameObject parentTransfer;
    public GameObject straightParent;
    public bool visible;
    public void instantiateStraight()
    {

        if (visible == true)
        {
            straight.transform.parent = parentTransfer.transform;
            var obj = Instantiate(straight) as GameObject;
            obj.transform.parent = straightParent.transform;
            obj.transform.localPosition = new Vector3(0.00281f, 0.00205f, 0.00141f);
            obj.transform.localRotation = Quaternion.Euler(-90f, 0f, 0f);
            obj.transform.localScale = new Vector3(0.4317433f, 0.4317433f, 0.4317433f);
            straight = obj;
        }
    }

    public void setVisible()
    {
        visible = !visible;
    }
}
