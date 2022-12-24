using System;
using System.Collections.Generic;
using System.Text;

namespace Task18._2._5
{
    class GateOpenAction : IAction
    {
        private Gate _gate;

        public GateOpenAction(Gate gateSet)
        {
            _gate = gateSet;
        }

        public void Run()
        {
            _gate.Open();
        }

        public void Undo()
        {
            _gate.Close();
        }
    }
}
