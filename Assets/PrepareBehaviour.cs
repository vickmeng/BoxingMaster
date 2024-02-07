using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepareBehaviour : StateMachineBehaviour
{
    // 10s的准备时间
    private int PrepareFrames = 600;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("开始");
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PrepareFrames -= 1;
        
    }

     // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (PrepareFrames<=0)
        {
            Debug.Log($"结束准备");
            animator.SetTrigger("FinishPrepare");
        }
    }
}
