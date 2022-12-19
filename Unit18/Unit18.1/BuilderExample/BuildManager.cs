using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    /// <summary>
    /// Объект, инкапсулирующий процесс строительства
    /// </summary>
    class BuildManager
    {
        IBuilder Builder;
        public BuildManager(IBuilder builder)
        {
            Builder = builder;
        }
        public void StartBuildingProcess()
        {
            Builder.FirstStage();
            Builder.SecondStage();
            Builder.ThirdStage();
        }
    }
}
