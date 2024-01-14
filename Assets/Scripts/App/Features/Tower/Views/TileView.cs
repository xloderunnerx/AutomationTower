using Composite.Core;
using UnityEngine;

namespace App.Features.Tower
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
