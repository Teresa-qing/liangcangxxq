//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace xxqLC
{
    using System;
    using System.Collections.Generic;
    
    public partial class MessageBoard
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ContentId { get; set; }
        public string MessageText { get; set; }
        public System.DateTime CreatDate { get; set; }
    
        public virtual ContentInfo ContentInfo { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
