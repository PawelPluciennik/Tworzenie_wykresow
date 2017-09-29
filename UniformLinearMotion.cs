using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tworzenie_wykresow
{
    class UniformLinearMotion
    {

        public UniformLinearMotion(double initialPosition, double initialVelocity)
        {
            InitialPosition = initialPosition;
            InitialVelocity = initialVelocity;
        }

        private double _initialVelocity;

        public double InitialVelocity
        {
            get
            {
                return _initialVelocity;
            }
            private set
            {
                _initialVelocity = value;
            }
        }


        private double _initialPosition;

        public double InitialPosition
        {
            get
            {
                return _initialPosition;
            }
            private set
            {
                _initialPosition = value;
            }
        }


        public override string ToString()
        {
            return String.Format("x(t) = {0} + {1} * t",InitialPosition,InitialVelocity);
        }

        public virtual double GetPosition(double time)
        {
            return InitialPosition + InitialVelocity * time;
        }
    }
}
