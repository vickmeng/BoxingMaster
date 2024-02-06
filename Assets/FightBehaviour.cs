using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightBehaviour : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        SwitchBehaviour  switchBehaviourInstance =  animator.GetBehaviour<SwitchBehaviour>();
        
        // switchBehaviourInstance.CurStatus = "Fight";
        // //
        // Debug.Log("set current as Fight");
    }
}
