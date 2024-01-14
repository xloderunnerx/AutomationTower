using Composite.Core;

namespace App.Features.TouchRaycast
{
	public class TouchRaycastFeature : AbstractFeature
	{
		public override void InstallBindings()
		{
			CompositionRoot.Bind<TouchRaycastModel>();
			CompositionRoot.BindFromHierarchy<TouchRaycastView>();
			CompositionRoot.BindController<TouchRaycastController>();
		}

		public override bool IsEnabled()
		{
			return CompositionRoot.GetInstance<TouchRaycastConfiguration>().isEnabled;
		}
	}
}