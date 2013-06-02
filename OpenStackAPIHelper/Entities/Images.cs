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

        public string DetailJson { get; set; }

        public override string ToString()
        {
            return Name;
        }

        //Detail data: v2/{tenant_id}/images/detail

        [DataMember(Name = "created")]
        public string Created { get; set; }
        [DataMember(Name = "minDisk")]
        public string MinDisk { get; set; }
        [DataMember(Name = "minRam")]
        public string MinRam { get; set; }
        [DataMember(Name = "progress")]
        public string Progress { get; set; }
        [DataMember(Name = "status")]
        public string Status { get; set; }
        [DataMember(Name = "updated")]
        public string Updated { get; set; }
        //[DataMember(Name = "metadata")]
        //public  Metadata { get; set; }
        //http://stackoverflow.com/questions/2297903/generic-wcf-json-deserialization

    }
}
