using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SelectionTarget : MonoBehaviour
{
    GameObject targetParent; //the parent to grab the children from
    public GameObject currentTarget, nextTarget, prevTarget;

    [SerializeField]int targetIndex, targetListLength;

    List<GameObject> childrenTargets = new List<GameObject>();

    //Get the children from the parent gameobject and calc length
    public void Init_SelecTargets(GameObject targetParent){
        this.targetParent = targetParent;
        foreach (Transform child in targetParent.GetComponentInChildren<Transform>()){
            childrenTargets.Add(child.gameObject);
        }
        targetListLength = childrenTargets.Count - 1;

        targetIndex = 0;
        currentTarget = childrenTargets[targetIndex];
        nextTarget = childrenTargets[targetIndex+1];
        prevTarget = currentTarget;
    }

    //Move to next target if not at the end of the list
    public void NextTarget(){
        if(ListTargetEnd()) return;

        targetIndex++;
        currentTarget = childrenTargets[targetIndex];

        if(ListTargetEnd())
            nextTarget = currentTarget;
        else
            nextTarget = childrenTargets[targetIndex+1];

        prevTarget = childrenTargets[targetIndex-1];
    }

    //Move to prev target if not at the begining of the list
    public void PrevTarget(){
        if(ListTargetBegin()) return;

        targetIndex--;
        currentTarget = childrenTargets[targetIndex];

        if(ListTargetBegin())
            prevTarget = currentTarget;
        else
            prevTarget = childrenTargets[targetIndex-1];

        nextTarget = childrenTargets[targetIndex+1];
    }

    //begin of list check
    bool ListTargetBegin()
    {
        if(targetIndex == 0) return true;
        return false;
    }

    //end of list check
    bool ListTargetEnd()
    {
        if(targetIndex == targetListLength) return true;
        return false;
    }
}
