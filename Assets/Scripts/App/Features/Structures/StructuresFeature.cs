using Composite.Core;

namespace App.Features.Structures
{
	public class StructuresFeature : AbstractFeature
	{
		public override void InstallBindings()
		{
			CompositionRoot.Bind<StructuresModel>();
			CompositionRoot.BindFromHierarchy<StructuresView>();
			CompositionRoot.BindController<StructuresController>();
		}

		public override bool IsEnabled()
		{
			return CompositionRoot.GetInstance<StructuresConfiguration>().isEnabled;
		}
	}
}