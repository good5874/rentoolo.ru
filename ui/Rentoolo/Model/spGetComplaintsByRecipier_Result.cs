//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    
    public partial class spGetComplaintsByRecipier_Result
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int СomplaintType { get; set; }
        public int ObjectId { get; set; }
        public int ObjectType { get; set; }
        public System.Guid UserSender { get; set; }
        public System.Guid UserRecipier { get; set; }
        public System.DateTime Data { get; set; }
        public string UserRecipierName { get; set; }
        public string UserSenderName { get; set; }
    }
}
