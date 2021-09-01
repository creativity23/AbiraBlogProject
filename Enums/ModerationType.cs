using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AbiraBlogProject.Enums
{
    public enum ModerationType
    {
        [Description("Offensive language")]
        Language,

        [Description("Drug references")]
        Drugs,

        [Description("Political propaganda")]
        Political,

        [Description("Threatening language")]
        Threatening,

        [Description("Hate speech")]
        HateSpeech,

        [Description("Sexual content")]
        Sexual,

        [Description("Targeted shaming")]
        Shaming
    }
}
