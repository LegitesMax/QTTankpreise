﻿//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTTankpreise.Logic.Contracts.Account
{
    using TOutModel = Models.Account.LoginSession;

    public partial interface ILoginSessionsAccess : IDataAccess<TOutModel>
    {
    }
}
#endif
//MdEnd
