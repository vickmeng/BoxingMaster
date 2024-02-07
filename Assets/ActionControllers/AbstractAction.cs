using UnityEngine;

namespace ActionControllers
{
    public abstract class AbstractAction
    {
        
        public abstract string ActionName { get; }
        
        public abstract bool Finish { get; }

        public int KeepFrames { get;  set;}
        
        protected readonly Animator Animator;
        protected AbstractAction(Animator animator)
        {
            this.Animator = animator;
        }
        
        public abstract void Next();
    }
}