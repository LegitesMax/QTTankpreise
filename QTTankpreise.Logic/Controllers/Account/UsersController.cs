﻿//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTTankpreise.Logic.Controllers.Account
{
    using EntityUser = Entities.Account.User;
    using OutModelUser = Models.Account.User;

    [Modules.Security.Authorize("SysAdmin", "AppAdmin")]
    internal sealed partial class UsersController : EntitiesController<EntityUser, OutModelUser>, Contracts.Account.IUsersAccess
    {
        public UsersController()
        {
        }

        public UsersController(ControllerObject other) : base(other)
        {
        }
    }
}
#endif
//MdEnd
