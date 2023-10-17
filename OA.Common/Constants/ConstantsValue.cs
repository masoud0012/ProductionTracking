using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Common.Constants
{
    public static class ConstantsValue
    {
        public static string successCode = "001";
        public static string successMessage = "عملیات با موفقیت انجام گردید.";

        public static string catchCode = "999";

        public static string notFoundCode = "002";
        public static string notFoundMsg = "مقداری یافت نشد";


        public static string ValueIsNotValidCode = "0003";
        public static string ValueIsNotValidMsg = "مقدار وارد شده معتبر نمی باشد.";

        public static string RequiredCode = "0006";
        public static string RequiredMsg = "مقادیر کامل وارد نشده است";

        public static string DuplicateCode = "0008";
        public static string DuplicateMsg = "کد تکراری می باشد.";

        public static string DuplicateNameCode = "0009";
        public static string DuplicateNameMsg = "نام تکراری می باشد.";

        public static string assignBalanceCode = "0010";
        public static string assignBalanceMsg = "مقدار تخصیص داده شده نباید بیشتر از مقدار موجودی اولیه باشد.";

        public static string assignedBeforeBalanceCode = "0010";
        public static string assignedBeforeBalanceMsg = "جنس انتخاب شده قبلا به انبار انتخابی تخصیص داده شده است.";

        public static string notAssignedBeforeBalanceCode = "0011";
        public static string notAssignedBeforeBalanceMsg = "جنس انتخاب شده قبلا به انبار انتخابی تخصیص داده نشده است.";

        public static string notFoundSalaryTypeCode = "0012";
        public static string notFoundSalaryTypeMsg = "نوع حقوق انتخابی وجود ندارد";


        public static string notFoundEmployeeTypeCode = "0013";
        public static string notFoundEmployeeTypeeMsg = "نوع کارمند انتخابی وجود ندارد";

        public static string notFoundUnitCode = "0014";
        public static string notFoundUnitMsg = "واحد اندازه گیری انتخابی موجود نمی باشد.";

        public static string notFoundTypeMaterialCode = "0015";
        public static string notFoundTypeMaterialMsg = "نوع جنس انتخابی موجود نمی باشد.";

        public static string notFoundUserCode = "0016";
        public static string notFoundUserMsg = "نام کاربری و یا کلمه عبور اشتباه است.";

        public static string missingFormatCode = "0017";
        public static string missingFormatMsg = "فرمت ورود اطلاعات صحیح نمی باشد.";

        public static string missingStockCountCode = "0018";
        public static string missingStockCountMsg = "موجودی انبار نمی تواند کمترا ز 1  باشد.";

        public static string notFoundCategoryCode = "0019";
        public static string notFoundCategoryMsg = "نوع دسته انتخابی موجود نمی باشد.";

        public static string userNameDuplicateCode = "0020";
        public static string userNameDuplicateMsg = "نام کاربر تکراری می باشد.";

        public static string notEamilNotValidCode = "0021";
        public static string notEmailNotValidMsg = "ایمیل وارد شده صحیح نمی باشد.";

        public static string notContractorNotValidCode = "0022";
        public static string notContractorNotValidMsg = "نوع پیمانکار مشخص نشده است.";


        public static string notContractorFullNameNotValidCode = "0023";
        public static string notContractorFullNameNotValidMsg = "ورود نام پیمانکار اجباری می باشد.";


        public static string notUserContractorFullNameNotValidCode = "0024";
        public static string notUserContractorFullNameNotValidMsg = "انتخاب کاربران پیمانکار اجباری می باشد.";


        public static string imageSizeErrorMessage = "حجم فایل از حد مجاز بزرگتر است.";
        public static string imageSizeErrorCode = "0025";

        public static string imageFormatErrorMessage = "امکان ارسال فایل های JPG,JPEG,PNG وجود دارد.";
        public static string imageFormatErrorCode = "0026";


        public static string notTotalPriceValidCode = "0027";
        public static string notTotalPriceValidMsg = "مجموع هزینه وارد نشده است.";

        public static string notHirePriceValidCode = "0028";
        public static string notHirePriceValidMsg = "مقدار اجرت پیمانکار خارجی وارد نشده است.";

        public static string AdminRole = "Admin";
        public static string NormalRole = "Normal";

        public static string HasAccessMessage = "HasAccess";
        public static string HasAccessCode = "HA";
        public static string NotHasAccessMessage = "Not Has Access";
        public static string NotHasAccessCode = "NHA";

        public static string NotTokenValidMessage = "Token Is Not Valid";
        public static string NotTokenValidCode = "TNA";

    }
}
