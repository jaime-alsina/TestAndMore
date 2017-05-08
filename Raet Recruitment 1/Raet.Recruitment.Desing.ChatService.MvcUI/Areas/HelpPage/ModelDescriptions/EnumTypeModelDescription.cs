using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Raet.Recruitment.Desing.ChatService.MvcUI.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}