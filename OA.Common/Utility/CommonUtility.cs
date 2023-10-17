using OA.Common.EnumValues;
using OA.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace OA.Common.Utility
{
    public static class CommonUtility
    {
        public static IEnumerable<TSource> DistinctByCutom<TSource, TKey>
        (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }


        public static TAttribute GetAttribute<TAttribute>(this Enum value)
            where TAttribute : Attribute
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            return type.GetField(name) // I prefer to get attributes this way
                .GetCustomAttributes(false)
                .OfType<TAttribute>()
                .SingleOrDefault();
        }

        public static string GetParentType(ParentEnum parent)
        {
           return parent.GetAttribute<System.ComponentModel.DescriptionAttribute>().Description.ToString();
        }
        public static string GetSalaryType(SalaryTypeEnum parent)
        {
            return parent.GetAttribute<System.ComponentModel.DescriptionAttribute>().Description.ToString();
        }

        public static string GetParentType(TableEnum parent)
        {
            return parent.GetAttribute<System.ComponentModel.DescriptionAttribute>().Description.ToString();
        }

        public static string GetParentType(ContractorTypes parent)
        {
            return parent.GetAttribute<System.ComponentModel.DescriptionAttribute>().Description.ToString();
        }


        public static T GetValueFromDescription<T>(string description) where T : Enum
        {
            foreach (var field in typeof(T).GetFields())
            {
                if (Attribute.GetCustomAttribute(field,
                typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }

            throw new CustomErrorException("Code Not Found", description);
            // Or return default(T);
        }

        public static string HashPassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }

        public static string ConvertMildiToPersian(DateTime dateTime)
        {
            string GregorianDate = dateTime.ToString();
            DateTime d = DateTime.Parse(GregorianDate);
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0}/{1}/{2}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));
        }

        public static string  generateCodeForGeneralParams(string pattern)
        {
            int number = Int32.Parse(pattern) + 1;
            string result = string.Empty;
            if (number < 10)
                result = "000" + number;
            else if (number < 100)
                result = "00" + number;
            else if (number < 1000)
                result = "0" + number;
            else if (number < 10000)
                result = "0" + number;
            return result;
        }

        public static  bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static DateTime ConvertPersianDateToGregorianDate(int year,int month , int day)
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = new DateTime(year, month, day, pc);
            return dt;
        }

        public static DateTime ConvertPersianDateToGregorian(string str)
        {
            DateTime dt = DateTime.Now;
            try
            {
                return DateTime.Parse(str);
            }
            catch (Exception ex)
            {

                throw new CustomErrorException("فرمت تاریخ صحیح نمی باشد.","000");
            }
            return dt;  
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

}
