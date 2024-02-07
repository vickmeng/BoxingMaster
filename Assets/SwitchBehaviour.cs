using ActionControllers;
using UnityEngine;

public class SwitchBehaviour : StateMachineBehaviour
{
    private ActionControllers.AbstractAction _curAction; 
    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("SwitchBehaviour OnStateEnter");
        if (_curAction!=null)
        {
            Debug.Log($"{_curAction.ActionName}的剩余帧数 is ==== {_curAction.KeepFrames}");
            if (_curAction.Finish)
            {
                //TODO
                if (_curAction.ActionName == "Break")
                {
                    _curAction = new FightAction(animator);
                }
                else
                {
                    _curAction = new BreakAction(animator);
                }
            }
        }
        else
        {
            _curAction = new FightAction(animator);
        }
        _curAction.Next();
    }


    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _curAction.KeepFrames -= 1;
    }
}
