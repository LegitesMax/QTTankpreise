﻿//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTTankpreise.Logic.Contracts.Account
{
    using QTTankpreise.Logic.Entities.Account;

    public partial interface IIdentityXRole
    {
        IdType IdentityId { get; set; }
        IdType RoleId { get; set; }
        Role? Role { get; set; }
    }
}
#endif
//MdEnd
