﻿using System;

namespace StoreClient.Entities.Zune
{
    public class ZuneArtistSearch
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
        public partial class feed
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("link")]
            public ZuneCommon.feedLink[] link { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
            public int startIndex { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
            public int totalResults { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
            public int itemsPerPage { get; set; }

            /// <remarks/>
            public DateTime updated { get; set; }

            /// <remarks/>
            public ZuneCommon.feedTitle title { get; set; }

            /// <remarks/>
            public string id { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("entry")]
            public feedEntry[] entry { get; set; }

            /// <remarks/>
            public ZuneCommon.feedAuthor author { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        public partial class feedEntry
        {
            /// <remarks/>
            public DateTime updated { get; set; }

            /// <remarks/>
            public ZuneCommon.feedEntryTitle title { get; set; }

            /// <remarks/>
            public string id { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public string sortName { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public ZuneCommon.primaryGenre primaryGenre { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public int playRank { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public uint playCount { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public ZuneCommon.image image { get; set; }
        }
    }
}
