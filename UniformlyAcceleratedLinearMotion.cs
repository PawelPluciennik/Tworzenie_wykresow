using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tworzenie_wykresow
{
    class UniformlyAcceleratedLinearMotion : UniformLinearMotion
    {
        public UniformlyAcceleratedLinearMotion(
            double initialPosition, 
            double initialVelocity, 
            double initialAcceleration) : base(initialPosition,initialVelocity)
        {
            InitialAcceleration = initialAcceleration;
        }


        private double _initialAcceleration;

        public double InitialAcceleration
        {
            get { return _initialAcceleration; }
            set { _initialAcceleration = value; }
        }

        public override string ToString()
        {
             return base.ToString()+String.Format(" + {0} * t^2 / 2",InitialAcceleration);
        }

        public override double GetPosition(double time)
        {
            return base.GetPosition(time) + 0.5 * InitialAcceleration * time * time;
        }
    }
}
