using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepareBehaviour : StateMachineBehaviour
{
    // 10s的准备时间
    private int PrepareFrames = 600;
    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PrepareFrames -= 1;
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (PrepareFrames<=0)
        {
            Debug.Log($"结束准备");
            animator.SetTrigger("FinishPrepare");
        }
    }
}
