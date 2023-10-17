using AutoMapper;
using OA.Common.Constants;
using OA.Common.Exceptions;
using OA.Common.Utility;
using OA.Data.Toural.Cost;
using OA.Repo.Troual.Contracts.ICost;
using OA.Service_.Toural.Contracts.Cost;
using OA.Service_.Toural.Contracts.JWTService;
using OA.Service_.Toural.ViewModels.Cost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Cost
{
    public class CostCategoryService: ICostCategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICostCategoryRepository _repository;
        private readonly IJWService _jwtService;
        public CostCategoryService(ICostCategoryRepository repository,
                                 IJWService jwtService,
                                IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._jwtService = jwtService;
        }



        public CostVM Edit(CostCategoryDto body)
        {

            var result = new CostVM();
            try
            {

                var entity = _repository.Get(body.ID);
                //var parent = _generalParameterRepository.Get(generalParamterPoco.ParentID);
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundCode, ConstantsValue.notFoundMsg);
                if (_repository.GetQuery(z => z.Title == body.Title && z.Id != body.ID) > 0)
                    throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateNameCode);
                entity.ModifiedById = this._jwtService.GetUserID();
                entity.Title = body.Title;
                entity.Description = body.Description;
                entity.ModifiedDate = DateTime.Now;
                _repository.Update(entity);
                _repository.SaveChanges();

            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public CostVM GetByID(long ID)
        {
            var result = new CostVM();
            try
            {
                result.costCategoryDto = _mapper.Map<CostCategoryEntity, CostCategoryDto>(_repository.Get(ID));
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        public CostVM Remove(long[] id)
        {
            var result = new CostVM();
            try
            {
                foreach (var item in id)
                {
                    var entity = _repository.Get(item);
                    entity.IsEnabled = false;
                    entity.ModifiedById = this._jwtService.GetUserID();
                }
                _repository.SaveChanges();
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public CostVM Search(CostCategoryDto body)
        {
            var result = new CostVM();
            try
            {

                if (body.Row <= 0)
                    throw new CustomErrorException(ConstantsValue.missingFormatMsg, ConstantsValue.missingFormatCode);

                var expression = query(z => (
                    (string.IsNullOrEmpty(body.Title) || z.Title.Contains(body.Title)) ||
                        string.IsNullOrEmpty(body.Title) || z.Code.Contains(body.Title) ||
                            string.IsNullOrEmpty(body.Title) || z.Description.Contains(body.Title) ||
                                string.IsNullOrEmpty(body.Title) || z.Id.ToString().Contains(body.Title)) &
                                    z.IsEnabled == true);

                var queryResult = _repository.GetQuery(expression, body.Page, body.Row, body.Sort);
                var countTable = _repository.GetQuery(expression);

                result.costCategoryDtos = _mapper.Map<List<CostCategoryEntity>, List<CostCategoryDto>>(queryResult);
                result.numberRows = countTable;
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        private Expression<Func<CostCategoryEntity, bool>> query(Expression<Func<CostCategoryEntity, bool>> expression)
        {
            return expression;
        }

        public CostVM Insert(CostCategoryDto body)
        {
            var result = new CostVM();
            try
            {
                if (string.IsNullOrEmpty(body.Title))
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                if (_repository.GetQuery(z => z.Title == body.Title) > 0)
                    throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateNameCode);
                var childEntity = new CostCategoryEntity();
                childEntity.CreatedById = this._jwtService.GetUserID();
                childEntity.Description = body.Description;
                childEntity.Code = CommonUtility.GetParentType(Common.EnumValues.TableEnum.CostCategory) + _repository.LastInsertedID();
                childEntity.Title = body.Title;
                childEntity.AddedDate = DateTime.Now;
                _repository.Insert(childEntity);
                _repository.SaveChanges();
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public CostVM GetAll()
        {
            var result = new CostVM();
            try
            {
                result.costCategoryDtos =
                    _mapper.Map<List<CostCategoryEntity>, List<CostCategoryDto>>(_repository.GetALL());
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public CostVM Remove(long id)
        {
            var result = new CostVM();
            try
            {
                var entity = _repository.Get(id);
                entity.IsEnabled = false;
                entity.ModifiedById = this._jwtService.GetUserID();
                _repository.SaveChanges();
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public CostVM Active(long id)
        {
            var result = new CostVM();
            try
            {
                var entity = _repository.GetQuery(z => z.Id == id, 1, 1, string.Empty).FirstOrDefault();
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                entity.IsEnabled = true;
                _repository.SaveChanges();
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public void SaveChanges()
        {
            _repository.SaveChanges();
        }
    }
}
