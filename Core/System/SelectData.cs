using Core.Data;

namespace Core.System
{
    public class SelectData
    {
        public T GetData<T>(DataType type, string id)
        {
            switch (type)
            {
                case DataType.Country:
                    {
                        return default(T);
                    }
                case DataType.Province:
                    {
                        return default(T);
                    }
                case DataType.Region:
                    {
                        return default(T);
                    }
                case DataType.City:
                    {
                        return default(T);
                    }
                case DataType.Farm:
                    {
                        return default(T);
                    }
                case DataType.Port:
                    {
                        return default(T);
                    }
                default:
                {
                    return default(T);
                }
            }
        }
    }
}