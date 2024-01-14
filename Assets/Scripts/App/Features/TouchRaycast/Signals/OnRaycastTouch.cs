using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace App.Features.TouchRaycast
{
    public class OnRaycastTouch
    {
        private RaycastHit hit;

        public OnRaycastTouch(RaycastHit hit)
        {
            this.hit = hit;
        }

        public RaycastHit Hit { get => hit; private set => hit = value; }
    }
}
