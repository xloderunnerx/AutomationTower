using Composite.Core;
using UnityEngine;

namespace App.Features.TouchRaycast
{
    public class TouchRaycastController : AbstractController, IUpdatable
    {
        public override void Initialize()
        {
        }

        public override void DeclareSignals()
        {
            DeclareSignal<OnRaycastTouchDown>();
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
                TryFireSignal(new OnRaycastTouchDown(CastRayFromCamera()));
            if (Input.GetKey(KeyCode.Mouse0))
                TryFireSignal(new OnRaycastTouchDown(CastRayFromCamera()));
        }

        private RaycastHit CastRayFromCamera()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            return hit;
        }
    }
}