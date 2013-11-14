using System;
using System.Configuration;

namespace TradePlatform.MT4.SDK.Library.Config
{
    public class ExpertElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ExpertElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ExpertElement)element).Name;
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }

        protected override string ElementName
        {
            get { return "Expert"; }
        }

        public ExpertElement this[string name]
        {
            get { return (ExpertElement)base.BaseGet(name); }
        }
    }
}
