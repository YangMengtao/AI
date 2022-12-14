using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.AI.BehaviorTree
{
    public class RepeatNode : DecoratorNode
    {
        protected override void OnStart()
        {
            
        }

        protected override void OnStop()
        {
            
        }

        protected override State OnUpdate()
        {
            if (m_Child != null)
            {
                m_Child.Update();
            }
            
            return State.Running;
        }
    }
}