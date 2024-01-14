using Composite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace App.Features.Structures
{
    public class TileView : AbstractView
    {
        public Vector3 worldPosition;
        public Vector3Int gridPosition;
        private MeshRenderer meshRenderer;

        private void Awake()
        {
            meshRenderer = GetComponent<MeshRenderer>();
        }

        public void SetTileColor(Color value)
        {
            meshRenderer.material.color = value;
        }
    }
}
