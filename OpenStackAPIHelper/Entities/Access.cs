using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OpenStackAPIHelper.Entities
{
    [DataContract]
    public class AccessWrapper
    {
        [DataMember(Name = "access")]
        public Access Access { get; set; }
    }

    [DataContract]
    public class Access
    {
        [DataMember(Name = "token")]
        public Token Token { get; set; }
        [DataMember(Name = "serviceCatalog")]
        public List<ServiceCatalogMember> ServiceCatalog { get; set; }
        [DataMember(Name = "user")]
        public NovaUser User { get; set; }
    }

    [DataContract]
    public class Token
    {
        [DataMember(Name = "expires")]
        public string Expires { get; set; }

        [DataMember(Name = "id")]
        public string tokenString { get; set; }

        [DataMember(Name = "tenant")]
        public Tenant Tenant { get; set; }
    }
    [DataContract]
    public class Tenant
    {
        [DataMember(Name = "enabled")]
        public string Enabled { get; set; }
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
    
    [DataContract]
    public class ServiceCatalogMember
    {
        [DataMember(Name = "endpoints")]
        public List<Endpoint> Endpoints { get; set; }
        [DataMember(Name = "endpoints_links")]
        public List<string> EndpointLinks { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
    [DataContract]
    public class Endpoint
    {
        [DataMember(Name = "region")]
        public string Region { get; set; }
        [DataMember(Name = "publicURL")]
        public string PublicUrl { get; set; }
        [DataMember(Name = "adminURL")]
        public string AdminUrl { get; set; }
        [DataMember(Name = "internalURL")]
        public string InternalUrl { get; set; }
    }

    [DataContract]
    public class NovaUser
    {
        [DataMember(Name = "username")]
        public string Username { get; set; }
        [DataMember(Name = "id")]
        public string id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "roles_links")]
        public List<string> RolesLinks { get; set; }
        [DataMember(Name = "roles")]
        public List<Roleset> Roles { get; set; }
    }
    [DataContract]
    public class Roleset
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "tenantId")]
        public string TenantId { get; set; }
    }

}




//{"access": 
//      {"token": 
//          {"expires": "2013-05-22T19:47:51Z", 
//              "id": "74d85841b71a451b8995a9e38f664264", 
//              "tenant": 
//                  {"enabled": true, "id": "inova-emailapps", "name": "inova-emailapps"}
//          }, 
//      "serviceCatalog": 
//          [
//              {"endpoints": [
//                  {"region": "preprodinova", 
//                    "publicURL": "https://10.24.193.52:8774/v2/inova-emailapps"}], 
//            "endpoints_links": [], 
//            "type": "compute", 
//            "name": "Compute Service"}
//          ], 
//      "user": 
//          {"username": "stev0560", 
//              "roles_links": [], 
//              "id": "stev0560", 
//              "roles": [{"name": "user"}], 
//              "name": "stev0560"
//          }, 
//      "metadata": {"is_admin": 0, "roles": ["user"]}
//      }
// }

