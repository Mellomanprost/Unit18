using System;
using System.Collections.Generic;
using System.Text;

namespace Task18._2._5
{
    class Pult
    {
        private IAction _action;

        public void SetAction(IAction action)
        {
            _action = action;
        }

        public void OpenButton()
        {
            _action.Run();
        }

        public void CloseButton()
        {
            _action.Undo();
        }
    }
}
