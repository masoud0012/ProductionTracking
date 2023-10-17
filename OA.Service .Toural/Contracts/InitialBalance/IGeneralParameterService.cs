using OA.Common.EnumValues;
using OA.Service_.Toural.ViewModels.InitialBalance;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.Contracts
{
    public interface IGeneralParameterService
    {
        InitialBalanceVM GetGeneralParamterByParentCode(ParentEnum Parent);
        InitialBalanceVM GetGeneralParamters();
        InitialBalanceVM GetGeneralParamters(string[] Codes);
        InitialBalanceVM GetAll();
        InitialBalanceVM Edit(GeneralParamterPoco generalParamterPoco);
        InitialBalanceVM GetByID(Int64 ID);
        InitialBalanceVM GetChildByID(long ID, ParentEnum parentEnum);
        InitialBalanceVM Search(GeneralParamterPoco body);
        InitialBalanceVM Insert(GeneralParamterPoco body);
        InitialBalanceVM Remove(long[] id);
        int getCurrentDaysOfMonth();
    }
}
