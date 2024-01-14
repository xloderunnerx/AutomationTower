using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace App.Features.TouchRaycast
{
    public class OnRaycastTouchDown
    {
        private RaycastHit hit;

        public OnRaycastTouchDown(RaycastHit hit)
        {
            this.hit = hit;
        }

        public RaycastHit Hit { get => hit; private set => hit = value; }
    }
}
