using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OpenStackAPIHelper.Entities
{
    [DataContract]
    public class Flavors
    {
        [DataMember(Name = "flavors")]
        public List<ServerImage> FlavorList { get; set; }
    }

    [DataContract]
    public class Images
    {
        [DataMember(Name = "images")]
        public List<ServerImage> ImageList { get; set; }
    }
    [DataContract]
    public class ServerImage
    {
        [DataMember(Name="id")]
        public string Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "links")]
        public List<ServerLink> Links { get; set; }

        public string SelfLink
        {
            get
            {
                var link = Links.FirstOrDefault(l => l.Rel == "self");
                return link == null ? null : link.Href;
            }
        }

        public string DetailJson { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
