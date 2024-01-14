using Composite.Core;

namespace App.Features.Tower
{
	public class TowerFeature : AbstractFeature
	{
		public override void InstallBindings()
		{
			CompositionRoot.Bind<TowerModel>();
			CompositionRoot.BindFromHierarchy<TowerView>();
			CompositionRoot.BindController<TowerController>();
		}

		public override bool IsEnabled()
		{
			return CompositionRoot.GetInstance<TowerConfiguration>().isEnabled;
		}
	}
}