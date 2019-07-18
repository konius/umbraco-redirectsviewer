﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Umbraco.Web.Mvc;

namespace Our.Umbraco.RedirectsViewer.Models
{
    [DataContract(Name = "RedirectSettings")]
    public class RedirectSettings
    {
        [DataMember(Name = "allowed")]
        public bool Allowed { get; set; }

        [DataMember(Name = "usergroups")]
        public List<string> UserGroups { get; set; }

        [DataMember(Name = "key")]
        public string Key { get; set; }

        public RedirectSettings()
        {
            UserGroups=new List<string>();
        }
    }
}
