using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AspNetWebApp1.DotNetFramework.MVC.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            this.Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}