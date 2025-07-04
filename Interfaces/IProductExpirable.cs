using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryE_CommAssesment2.Interfaces
{
    public interface IProductExpirable
    {
        DateTime ExpiryDate { get; }
        bool IsExpired();

    }
}
