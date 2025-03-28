using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTree.Models
{
    public class Resource : IDisposable
    {
        private bool _isDisposed = false;
        public int Argument
        {
            get
            {
                if (!_isDisposed)
                    return 5;
                else throw new ObjectDisposedException("Resource");
            }
        }

        public void Dispose()
        {
            _isDisposed = true;
        }
    }
}
