using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildrenTransfer : MonoBehaviour
{
    public GameObject Parent2Be;
    public GameObject Child2Transfer;

    public void SetPArent(GameObject newParent)
    {
        Child2Transfer.transform.parent = newParent.transform;
        Debug.Log("Child2Transfer's Parent: " + Child2Transfer.transform.parent.name);

        if(newParent.transform.parent != null)
        {
            Debug.Log("Child2Transfer's Ground parent: " + Child2Transfer.transform.parent.parent.name);
        }
    }
    
    public void DetachFromParent()
    {
        Child2Transfer.transform.parent = null;
    }

    public void TransferChildObject()
    {
        Child2Transfer.transform.parent = Parent2Be.transform;
    }
}
