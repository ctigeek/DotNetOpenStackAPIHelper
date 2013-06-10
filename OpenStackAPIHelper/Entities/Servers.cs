using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OpenStackAPIHelper.Entities
{
    [DataContract]
    public class Servers
    {
        [DataMember(Name = "servers")]
        public List<Server> ServerList { get; set; }
    }

    [DataContract]
    public class Server
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "links")]
        public List<ServerLink> Links { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        public string SelfLink
        {
            get
            {
                if (Links != null)
                {
                    var link = Links.FirstOrDefault(l => l.Rel == "self");
                    return link == null ? null : link.Href;
                }
                return null;
            }
        }
        public string Region
        {
            get
            {
                return SelfLink == null ? null : SelfLink.Substring(8, 3);
            }
        }
        public string DetailJson { get; set; }

        public override string ToString()
        {
            return Region == null ?
                    Name :
                    "(" + Region + ") " + Name;
        }
    }

    [DataContract]
    public class ServerLink
    {
        [DataMember(Name = "href")]
        public string Href { get; set; }
        
        [DataMember(Name = "rel")]
        public string Rel { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }
    }
}
