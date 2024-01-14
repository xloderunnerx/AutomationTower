using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace App.Features.Structures
{
    public abstract class AbstractStructureModel
    {
        protected Vector3 worldPosition;
        protected Vector3Int gridPosition;

        public abstract void Update();
    }
}
