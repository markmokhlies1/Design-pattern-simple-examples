using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class ObjectPool
    {
        private readonly Stack<ReusableObject> _avalibaleObjects = new Stack<ReusableObject>();
        private int _nextId = 1;

        public ReusableObject GetObject()
        {
            if(_avalibaleObjects.Count >0)
            {
                return _avalibaleObjects.Pop();
            }
            return new ReusableObject(_nextId);
        }

        public void ReturnObject(ReusableObject obj)
        {
            obj.Reset();
            _avalibaleObjects.Push(obj);
        }
    }
}
