//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DragonBallMatching
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImagesTable
    {
        public int ImageNotImportant { get; set; }
        public Nullable<int> ImageID { get; set; }
        public string Images { get; set; }
    
        public virtual UsersTable UsersTable { get; set; }
    }
}
