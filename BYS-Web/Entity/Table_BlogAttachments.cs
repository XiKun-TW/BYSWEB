//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BYS_Web.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_BlogAttachments
    {
        public System.Guid ID { get; set; }
        public System.Guid BlogID { get; set; }
        public string FileName { get; set; }
        public string FileSize { get; set; }
    
        public virtual Table_Blog Table_Blog { get; set; }
    }
}
