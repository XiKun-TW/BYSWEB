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
    
    public partial class Table_User
    {
        public Table_User()
        {
            this.Table_Answer = new HashSet<Table_Answer>();
            this.Table_OperationLog = new HashSet<Table_OperationLog>();
            this.Table_Question = new HashSet<Table_Question>();
            this.Table_Blog = new HashSet<Table_Blog>();
        }
    
        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public bool Sexy { get; set; }
        public System.DateTime Date { get; set; }
        public string Comments { get; set; }
        public string Photo { get; set; }
        public Nullable<int> Rate { get; set; }
    
        public virtual ICollection<Table_Answer> Table_Answer { get; set; }
        public virtual ICollection<Table_OperationLog> Table_OperationLog { get; set; }
        public virtual ICollection<Table_Question> Table_Question { get; set; }
        public virtual ICollection<Table_Blog> Table_Blog { get; set; }
    }
}
