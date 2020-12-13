using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startTransfer : MonoBehaviour
{
    public GameObject Child2Transfer;
    public GameObject Parent2Be;
    public bool visible = true;
    
    public void transferParent()
    {
       if(visible == true)
        Child2Transfer.transform.parent = Parent2Be.transform;
    }

    public void setVisible()
    {
        visible = !visible;
    }
}
