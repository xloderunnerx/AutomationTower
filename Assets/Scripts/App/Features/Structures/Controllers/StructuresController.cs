using Composite.Core;

namespace App.Features.Structures
{
	public class StructuresController : AbstractController
	{
		private StructuresView view;
		private StructuresConfiguration configuration;
		private StructuresModel model;

        public StructuresController(StructuresView view, StructuresConfiguration configuration, StructuresModel model)
        {
            this.view = view;
            this.configuration = configuration;
            this.model = model;
        }

        public override void Initialize()
		{
		}
	}
}