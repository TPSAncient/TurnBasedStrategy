using System.Security.Cryptography.X509Certificates;

namespace Core.Data.Common
{
    public interface IUIData : IData
    {
         string TagRegion { get; set; }
         string TagLocation { get; set; }
    }
}