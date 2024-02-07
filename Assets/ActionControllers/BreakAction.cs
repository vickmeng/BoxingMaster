using UnityEngine;

namespace ActionControllers
{
    public class BreakAction : ActionControllers.AbstractAction
    {
        public override string ActionName => "Break";
        
        public override bool Finish => KeepFrames<=0;


        public BreakAction(Animator animator) : base(animator)
        {
            KeepFrames = Random.Range(600, 1200);
            Debug.Log($"切换为 Break，{KeepFrames}");
        }

        public override void Next()
        {
            //继续休息也干不了别的
            this.Animator.SetTrigger("Break");
        }
    }
}