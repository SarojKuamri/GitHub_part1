using System;

namespace AuthSystem.Areas.Identity.Data
{
    internal class columnAttribute : Attribute
    {
        public string TypeName { get; set; }
    }
}