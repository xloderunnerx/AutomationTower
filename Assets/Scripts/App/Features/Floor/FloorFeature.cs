using Composite.Core;

namespace App.Features.Floor
{
	public class FloorFeature : AbstractFeature
	{
		public override void InstallBindings()
		{
			CompositionRoot.Bind<FloorModel>();
			CompositionRoot.BindFromHierarchy<FloorView>();
			CompositionRoot.BindController<FloorController>();
		}

		public override bool IsEnabled()
		{
			return CompositionRoot.GetInstance<FloorConfiguration>().isEnabled;
		}
	}
}