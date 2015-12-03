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
            StaticPort port = new StaticPort();

            port.Name = name;
            port.TagName = tagName;
            port.DataType = DataType.Port;
            return port;
        }
    }
}