using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using TrackingLibrary.TrackingClasses;

namespace TrackingLibrary
{
    public class Logger
    {
        private string file;


        public Logger(string fileName)
        {
            if (!String.IsNullOrEmpty(fileName))
            {
                file = fileName;
            }
            else
            {
                throw new ArgumentException("Invalid file.");
            }
        }

        public void Track(object arbitaryObj)
        {
            Dictionary<string, string> unserializedResult = new Dictionary<string, string>();

            if ((TrackingEntity)Attribute.GetCustomAttribute(arbitaryObj.GetType(), typeof(TrackingEntity)) != null)
            {
                foreach (var prop in arbitaryObj.GetType().GetProperties())
                {
                    var attribut = (TrackingProperty)Attribute.GetCustomAttribute(prop, typeof(TrackingProperty));

                    if (attribut != null)
                    {
                        unserializedResult.Add(attribut.PropertyName != null ? attribut.PropertyName : prop.Name, prop.GetValue(arbitaryObj).ToString());
                    }
                }

                foreach (var field in arbitaryObj.GetType().GetFields())
                {
                    var attribut = (TrackingProperty)Attribute.GetCustomAttribute(field, typeof(TrackingProperty));

                    if (attribut != null)
                    {
                        unserializedResult.Add(attribut.PropertyName != null ? attribut.PropertyName : field.Name, field.GetValue(arbitaryObj).ToString());
                    }
                }

                File.WriteAllText(file, JsonSerializer.Serialize(unserializedResult));
            }
            else
            {
                throw new ArgumentException("Attribute isn't defined.");
            }
        }
    }
}
