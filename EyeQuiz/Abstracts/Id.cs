using System;
using System.Xml.Serialization;

namespace EyeQuiz.Abstracts
{
    public abstract class Id
    {
        [XmlAttribute]
        public Guid Guid { get; set; }

        protected Id()
        {
            Guid = Guid.NewGuid();
        }
    }
}