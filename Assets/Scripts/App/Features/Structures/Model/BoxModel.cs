using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace App.Features.Structures
{
    public class BoxModel : AbstractStructureModel
    {
        public BoxModel(Vector3 worldPosition, Vector3Int gridPosition)
        {
            this.worldPosition = worldPosition;
            this.gridPosition = gridPosition;
        }

        public override void Update()
        {
            
        }
    }
}
