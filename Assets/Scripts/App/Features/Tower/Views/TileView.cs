using Composite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace App.Features.Tower
{
    public class TileView : AbstractView
    {
        public int height;
        public Vector2Int gridPosition;
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
