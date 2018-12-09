using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class CompositeValidate : IComponentValidate
    {
        private List<IComponentValidate> _objects;
        private Arrangement _arrangement;
        private List<dynamic> _results;

        public CompositeValidate()
        {
            this._objects = new List<IComponentValidate>();
            this._results = new List<dynamic>();
        }

        public void SetArrangement(Arrangement arm)
        {
            this._arrangement = arm;
        }

        public void AddComponent(IComponentValidate cpn)
        {
            this._objects.Add(cpn);
        }

        public bool Validate()
        {
            bool IsValid = true;
            foreach (IComponentValidate cpn in this._objects)
            {
                if (cpn.Validate() == false && IsValid == true)
                {
                    IsValid = cpn.Validate();
                }
                this._results.Add(cpn.GetResult(this._arrangement));
            }
            return IsValid;
        }
        public bool IsValid()
        {
            return Validate();
        }

        public dynamic GetResult(Arrangement arm)
        {
            return this._results;
        }
        public dynamic ValidateAndGetResult(Arrangement arm)
        {
            if (Validate())
                return null;
            else
                return GetResult(arm);
        }
    }
}