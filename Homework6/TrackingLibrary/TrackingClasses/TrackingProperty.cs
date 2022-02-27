using System;

namespace TrackingLibrary.TrackingClasses
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class TrackingProperty : Attribute
    {
        public string PropertyName { get; set; }


        public TrackingProperty() { }
        public TrackingProperty(string propName)
        {
            PropertyName = propName;
        }
    }
}
