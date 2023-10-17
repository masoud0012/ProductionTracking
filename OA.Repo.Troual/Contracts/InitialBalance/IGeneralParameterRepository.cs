using OA.Common.EnumValues;
using OA.Data.BaseEntities;
using OA.Data.Toural.InitialBalance;
using OA.Repo.Troual.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OA.Repo.Troual.Contracts.InitialBalance
{
    public interface IGeneralParameterRepository
    {
        List<GeneralParameter> GetGeneralParameters();
        List<GeneralParameter> GetParametersParents();
        GeneralParameter Get(long id);
        GeneralParameter GetChildById(long id);
        GeneralParameter GetParentByCode(string code);
        GeneralParameter GetCParentByCodAndId(long id,string Code);
        GeneralParameter GetChild(long id, ParentEnum parentEnum);
        void Insert(GeneralParameter entity);
        void Update(GeneralParameter entity);
        void Delete(GeneralParameter entity);
        void Remove(GeneralParameter entity);
        void SaveChanges();
        List<GeneralParameter> GetGeneralParamterByParentCode(string Parent);
        GeneralParameter GetParentByCodeStr(string Parent);
        GeneralParameter GetById(long ID);
        List<GeneralParameter> GetQuery(Expression<Func<GeneralParameter, bool>> predicate, int Page, int Row, string orderBy);

        int GetQuery(Expression<Func<GeneralParameter, bool>> predicate);
        List<GeneralParameter> GetChildByParentID(long id);
    }
}
