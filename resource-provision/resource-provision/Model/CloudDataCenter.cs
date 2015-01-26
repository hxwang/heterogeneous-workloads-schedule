using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace resource_provision.Model
{
    class CloudDataCenter
    {
        public List<Server> ServerList { get; private set; }


        public void AddServer(Server server) {
            ServerList.Add(server);
        }

        public void ReleaseServer(Server server) {
            if (ServerList.Contains(server))
                ServerList.Remove(server);
            else
                throw new InvalidOperationException("Server not existed! Fail to remove!");
     
        }
    }
}
