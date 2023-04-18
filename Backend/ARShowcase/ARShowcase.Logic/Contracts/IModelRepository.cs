using ARShowcase.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ARShowcase.Logic.Contracts
{
    interface IModelRepository
    {
        void AddModel(string modelName);
        IEnumerable<Model> GetModels();
        Model GetModelById();
    }
}
