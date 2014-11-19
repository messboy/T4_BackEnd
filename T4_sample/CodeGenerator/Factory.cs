using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeGenerator.Template;

namespace CodeGenerator
{
    class Factory
    {
        private Model.BaseModel model;

        public Interface Interface { get; set; }


        public Factory(Model.BaseModel model)
        {
            switch (model.TypeName)  
            {
                case "DLL":
                    Interface = new DLLTemp(model);
                break;
                case "BLL":
                    Interface = new DLLTemp(model);
                break;
                case "Controller":
                    Interface = new DLLTemp(model);
                break;
                case "ViewIndex":
                    Interface = new DLLTemp(model);
                break;
                case "ViewPage":
                    Interface = new DLLTemp(model);
                break;

            }
        }

    }
}
