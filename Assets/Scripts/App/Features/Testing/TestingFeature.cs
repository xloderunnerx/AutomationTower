using Composite.Core;

namespace App.Features.Testing
{
	public class TestingFeature : AbstractFeature
	{
		public override void InstallBindings()
		{
			CompositionRoot.Bind<TestingModel>();
			CompositionRoot.BindFromHierarchy<TestingView>();
			CompositionRoot.BindController<TestingController>();
		}

		public override bool IsEnabled()
		{
			return CompositionRoot.GetInstance<TestingConfiguration>().isEnabled;
		}
	}
}