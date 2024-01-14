using App.Features.TouchRaycast;
using App.Features.Tower;
using Composite.Core;
using System;
using UnityEngine;

namespace App.Features.Testing
{
	public class TestingController : AbstractController
	{
		private TestingView view;
		private TestingConfiguration configuration;

        public TestingController(TestingView view, TestingConfiguration configuration)
        {
            this.view = view;
            this.configuration = configuration;
        }

        public override void SubscribeToSignals()
        {
            SubscribeToSignal<OnRaycastTouchDown>(signal => ColorChangeTiles(signal));
        }

        private void ColorChangeTiles(OnRaycastTouchDown signal)
        {
            if (signal.Hit.collider == null)
                return;
            var tileView = signal.Hit.collider.gameObject.GetComponent<TileView>();
            if (tileView == null)
                return;
            tileView.SetTileColor(Color.green);
        }

        public override void Initialize()
		{
		}
	}
}