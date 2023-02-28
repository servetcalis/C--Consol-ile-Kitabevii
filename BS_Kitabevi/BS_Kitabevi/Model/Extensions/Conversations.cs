using BS_Kitabevi.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_Kitabevi.Model.Extensions
{
    internal static class Conversations
    {
        public static string GetStatu(this StatuType type)
        {
            switch (type)
            {
                case StatuType.Active:
                    return "Aktif";
                case StatuType.Passive:
                    return "Pasif";
                default:
                    return "Belirtilmedi";
            }
        }
    }
}
