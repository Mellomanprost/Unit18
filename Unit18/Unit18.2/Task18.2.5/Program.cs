using System;

namespace Task18._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Pult pult = new Pult();
            Gate gate = new Gate();

            pult.SetAction(new GateOpenAction(gate));
            pult.OpenButton();
            pult.CloseButton();
        }
    }
}
