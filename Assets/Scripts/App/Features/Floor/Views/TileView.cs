using Composite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace App.Features.Floor
{
    public class TileView : AbstractView
    {
        public Vector3Int position;
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
