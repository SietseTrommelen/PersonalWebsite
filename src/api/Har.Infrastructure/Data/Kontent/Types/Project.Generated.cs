// This code was generated by a kontent-generators-net tool 
// (see https://github.com/Kentico/kontent-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery.Abstractions;

namespace Har.Infrastructure.Data.Kontent.Types
{
    public partial class Project
    {
        public const string Codename = "project";
        public const string AuthorCodename = "author";
        public const string ContentCodename = "content";
        public const string OnlineSinceCodename = "online_since";
        public const string ShortDescriptionCodename = "short_description";
        public const string SiteUrlCodename = "site_url";
        public const string TechnologiesCodename = "technologies";

        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime? OnlineSince { get; set; }
        public string ShortDescription { get; set; }
        public string SiteUrl { get; set; }
        public IContentItemSystemAttributes System { get; set; }
        public string Technologies { get; set; }
    }
}