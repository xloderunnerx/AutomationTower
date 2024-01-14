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
        public Vector3 worldPosition;
        public Vector3Int gridPosition;

        public abstract void Update();
    }
}
