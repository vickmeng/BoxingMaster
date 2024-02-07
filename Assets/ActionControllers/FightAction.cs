using UnityEngine;

namespace ActionControllers
{
    public class FightAction : ActionControllers.AbstractAction
    {
        
        public override string ActionName => "Fight"; 
        public override bool Finish => KeepFrames<=0;

        public FightAction(Animator animator) : base(animator)
        {
            KeepFrames = Random.Range(1200, 4800);
            
            Debug.Log($"切换为 Fight，{KeepFrames}");
        }
        public override void Next()
        {
            //TODO 换打击动作
            this.Animator.SetTrigger("Fight");
        }
    }
}