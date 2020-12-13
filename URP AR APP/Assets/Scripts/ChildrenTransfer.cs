using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildrenTransfer : MonoBehaviour
{
    public GameObject Parent2Be;
    public GameObject RightChild2Transfer;
    public GameObject LeftChild2Transfer;
    public GameObject StraightChild2Transfer;
    public GameObject RightParent;
    public GameObject LeftParent;
    public GameObject StraightParent;
    private Vector3 rightPos;
    private Vector3 leftPos;
    private Vector3 straightPos;
    public bool right;
    public bool left;
    public bool straight;
    public bool leftVisible;
    public bool rightVisible;
    public bool straightVisible;


    private void Start()
    {
        right = false;
        left = false;
        straight = false;
        leftVisible = false;
        rightVisible = false;
        straightVisible = false;
    }

    public void SetParent(GameObject newParent)
    {
        if (right == true)
        {
            RightChild2Transfer.transform.parent = newParent.transform;
            Debug.Log("Child2Transfer's Parent: " + RightChild2Transfer.transform.parent.name);

            if (newParent.transform.parent != null)
            {
                Debug.Log("RightChild2Transfer's Ground parent: " + RightChild2Transfer.transform.parent.parent.name);
            }
        }

        if (left == true)
        {
            LeftChild2Transfer.transform.parent = newParent.transform;
            Debug.Log("Child2Transfer's Parent: " + LeftChild2Transfer.transform.parent.name);

            if (newParent.transform.parent != null)
            {
                Debug.Log("RightChild2Transfer's Ground parent: " + LeftChild2Transfer.transform.parent.parent.name);
            }
        }

        if (straight == true)
        {
            StraightChild2Transfer.transform.parent = newParent.transform;
            Debug.Log("Child2Transfer's Parent: " + StraightChild2Transfer.transform.parent.name);

            if (newParent.transform.parent != null)
            {
                Debug.Log("RightChild2Transfer's Ground parent: " + StraightChild2Transfer.transform.parent.parent.name);
            }
        }
    }

    private void Update()
    {
        rightPos = RightParent.transform.position;
        leftPos = LeftParent.transform.position;
        straightPos = StraightParent.transform.position;
    }

    public void DetachFromParent()
    {
        RightChild2Transfer.transform.parent = null;
    }

    public void TransferChildObject()
    {

        if (right == true && rightVisible == true)
        {
            RightChild2Transfer.transform.parent = Parent2Be.transform;
            var obj = Instantiate(RightChild2Transfer) as GameObject;
            obj.transform.parent = RightParent.transform;
            obj.transform.localPosition = new Vector3(0.00281f, 0.00205f, 0.00141f);
            obj.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
            

           
        }
        
        if(left == true && leftVisible == true)
        {


            //var obj = Instantiate(LeftChild2Transfer) as GameObject;





        }

        if(straight == true && straightVisible == true)
        {
            StraightChild2Transfer.transform.parent = Parent2Be.transform;
            var obj = Instantiate(StraightChild2Transfer) as GameObject;
            obj.transform.parent = StraightParent.transform;
            obj.transform.localPosition = new Vector3(0.00281f, 0.00205f, 0.00141f);
            obj.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
            
        }
    }

    public void leftCheck()
    {
        left = !left;
        leftVisible = !leftVisible;
        
    }

    public void rightCheck()
    {
        right = !right;
        rightVisible = !rightVisible;
        
    }

    public void straightCheck()
    {
        straight = !straight;
        straightVisible = !straightVisible;
        
    }
}
