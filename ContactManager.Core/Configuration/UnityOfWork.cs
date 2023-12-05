using ContactManager.Core.IConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Core.Configuration
{
    public class UnityOfWork : IUnityOfWork, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
