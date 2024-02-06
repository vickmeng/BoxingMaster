using UnityEngine;

public class SwitchBehaviour : StateMachineBehaviour
{
    public string CurStatus = "Break";
    // 当前状态持续的帧数
    private int CurStatusKeepFrames = 600;

    // 当前状态完成了
    public bool CurStatusFinished
    {
        get
        {
            return CurStatusKeepFrames <= 0;
        }
    }
    
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log($"当前状态 is ==== {CurStatus}");
        Debug.Log($"剩余帧数 is ==== {CurStatusKeepFrames}");

        CheckAndSwitchToOtherStatus(animator);
    }


    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        CurStatusKeepFrames -= 1;
    }

    private void CheckAndSwitchToOtherStatus(Animator animator)
    {
        if (CurStatus=="Break")
        {
            if (CurStatusFinished)
            {
                SwitchToFight(animator);
            }
            else
            {
                animator.SetTrigger("Break");
                //啥也不干 继续休息
            }
        }
        else if (CurStatus=="Fight")
        {
            if (CurStatusFinished)
            {
                SwitchToBreak(animator);   
            }
            else
            {
                animator.SetTrigger("Fight");
            }
            
        }
        
    }

    private void SwitchToBreak(Animator animator)
    {
        Debug.Log("切换至 ==== Break");
        
        // 10~ 30s
        int randomNumber = Random.Range(600, 1800);
        CurStatusKeepFrames = randomNumber;
        CurStatus = "Break";
        animator.SetTrigger("Break");
    }
    
    private void SwitchToFight(Animator animator)
    {
        Debug.Log("切换至 ==== Fight");
        // 10~ 60s
        int randomNumber = Random.Range(1800, 3600);
        CurStatusKeepFrames = randomNumber;
        CurStatus = "Fight";
        animator.SetTrigger("Fight");
    }
    
    private void SwitchToMove()
    {
        //TODO
    }
}
