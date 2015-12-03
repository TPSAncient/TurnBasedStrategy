using Core.Data.Common;
using Core.Data.World.Region.Port;

namespace Core.Test.Data
{
    public class SeedPortData
    {

        public StaticDictionary<StaticPort> Ports;
        public SeedPortData()
        {
            Ports = new StaticDictionary<StaticPort>();

            StaticPort port;

            port = AddPort("Roma Port", "port_roma");
            Ports.Add(port.TagName, port);

            port = AddPort("Velathri Port", "port_velathri");
            Ports.Add(port.TagName, port);

            port = AddPort("Ariminum Port", "port_ariminum");
            Ports.Add(port.TagName, port);
        }

        private StaticPort AddPort(string name, string tagName)
        {
            StaticPort industry = new StaticPort();

            industry.Name = name;
            industry.TagName = tagName;
            industry.DataType = DataType.Port;
            return industry;
        }
    }
}