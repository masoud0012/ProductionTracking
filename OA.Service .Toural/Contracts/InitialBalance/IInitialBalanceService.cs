using Microsoft.AspNetCore.Http;
using OA.Data.Toural.FlowProcess;
using OA.Service_.Toural.ViewModels.Cost;
using OA.Service_.Toural.ViewModels.InitialBalance;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.Contracts
{
    public interface IInitialBalanceService
    {
        InitialBalanceVM Insert(InitialBalancePoco Entity, IFormFile formFile, FlowProcessEntity flowProcessEntity);
        InitialBalanceVM GetAll();
        InitialBalanceVM Remove(long[] id);
        InitialBalanceVM GetByID(Int64 ID);
        InitialBalanceVM GetByFlowID(Int64 ID);
        InitialBalanceVM SearchBy(InitialBalancePoco body);
        InitialBalanceVM SearchWastage(InitialBalancePoco body);
        InitialBalanceVM CalculateByJob();
        InitialBalanceVM SearchAutoComplete(InitialBalancePoco body);

        InitialBalanceVM Update(InitialBalancePoco body, IFormFile formFile);
        InitialBalanceVM EditBalanceStock(InitialBalancePoco body);
        InitialBalanceVM GetWestage(InitialBalancePoco body);
        InitialBalanceVM Remove(long id);
        InitialBalanceVM Active(long id);
        InitialBalanceVM GetBalanceStockByID(long id);
        InitialBalanceVM SearchAutoCompleteExcept(InitialBalancePoco body);
        InitialBalanceVM CalculateProducts(DateTime startMiladiDate,DateTime endMiladiDate, Decimal totalCostPrice);
        InitialBalanceVM SearchFinalProduct(InitialBalancePoco body);
        ExcelDto PrintExcel();
        ExcelDto PrintWastage(InitialBalancePoco body);

        ExcelDto PrintWastage();

        InitialBalanceVM SearchAutoCompleteByID(Int64 ID);
        InitialBalanceVM CalculateBalanceNewPrice(Int64 ID,FlowProcessEntity flowProcessEntity, long Count);

    }
}
