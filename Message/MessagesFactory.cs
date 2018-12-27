using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validate.Message
{
    class MessagesFactory
    {
        private MessagesFactory()
        {
        }

        public static MessagesContainer Create()
        {
            return Create(LangCode.vi);
        }

        public static MessagesContainer Create(LangCode code)
        {
            switch (code)
            {
                case LangCode.en:
                    return new MessagesContainer()
                    {
                        IsNotNullMessage = "'{0}' cannot be null.",
                        IsNotNullOrEmptyMessage = "'{0}' cannot be null or empty.",
                        IsNotNullOrWhiteSpaceMessage = "'{0}' cannot be null or whitespace only.",
                        IsNotZeroMessage = "'{0}' cannot be zero.",
                        IsPasswordMessage = "'{0}' is not a valid password. Passwords must be 8 to 30 characters, at least on 1 uppercase letter, at least 1 lowercase letter and at least one number.",
                        IsMinLengthMessage = "'{0}' must be a at least {1} characters.",
                        IsMaxLengthMessage = "'{0}' must be {1} characters or less.",
                        IsExactLengthMessage = "'{0}' must be exactly {1} characters.",
                        IsBetweenLengthMessage = "'{0}' must be at least {1} and at most {2} characters.",
                        IsMessage = "'{0}' does not match the specified criteria.",
                        IsNotMessage = "'{0}' does not match the specified criteria.",
                        IsEmailMessage = "'{0}' is not a valid email address.",
                        IsRegexMessage = "'{0}' does not match the provided regular expression.",
                        IsMatchMessage = "'{0}' did not match the specified criteria.",
                        IsDateMessage = "'{0}' is not a valid date.",
                        IsRuleMessage = "'{0}' failed the provided business rule provided.",
                        IsGreaterThanMessage = "'{0}' must be greater than '{1}'.",
                        IsGreaterThanOrEqualToMessage = "'{0}' must be greater than or equal to '{1}'.",
                        IsLessThanMessage = "'{0}' must be less than '{1}'.",
                        IsLessThanOrEqualToMessage = "'{0}' must be less than or equal to '{1}'.",
                        IsEqualToMessage = "'{0}' must be equal to '{1}'.",
                        IsBetweenInclusiveMessage = "'{0}' must be between '{1}' and '{2}' (inclusive).",
                        IsBetweenExclusiveMessage = "'{0}' must be between '{1}' and '{2}' (exclusive)."
                    };
                case LangCode.vi:
                    return new MessagesContainer()
                    {
                        IsNotNullMessage = "'{0}' không được phép null.",
                        IsNotNullOrEmptyMessage = "'{0}' không được phép rỗng hay null .",
                        IsNotNullOrWhiteSpaceMessage = "'{0}'  không được phép null hay chỉ chứa khoảng trắng.",
                        IsNotZeroMessage = "'{0}' không thể bằng 0.",
                        IsPasswordMessage = "'{0}' không phải mật khẩu. Mật khảu phải từ 8 đến 30 kí tự, ít nhất một chữ hoa, một chữ thường và một số.",
                        IsMinLengthMessage = "'{0}' phải ít nhất có {1} kí tự.",
                        IsMaxLengthMessage = "'{0}' phải có nhiều nhất {1} kí tự.",
                        IsExactLengthMessage = "'{0}' phải có đúng {1} kí tự",
                        IsBetweenLengthMessage = "'{0}' phải có ít nhất {1} và nhiều nhất {2} kí tự.",
                        IsMessage = "'{0}' không thỏa điều kiện.",
                        IsNotMessage = "'{0}' không thỏa điều kiện.",
                        IsEmailMessage = "'{0}' không phải email.",
                        IsRegexMessage = "'{0}' không thỏa biểu thức chính quy cho trước.",
                        IsMatchMessage = "'{0}' không thỏa điều kiện.",
                        IsDateMessage = "'{0}' không phải ngày hợp lệ.",
                        IsRuleMessage = "'{0}' failed the provided business rule provided.",
                        IsGreaterThanMessage = "'{0}' phải lớn hơn '{1}'.",
                        IsGreaterThanOrEqualToMessage = "'{0}' phải lớn hơn hoặc bằng '{1}'.",
                        IsLessThanMessage = "'{0}' phải nhỏ hơn '{1}'.",
                        IsLessThanOrEqualToMessage = "'{0}' phải nhỏ hơn hoặc bằng '{1}'.",
                        IsEqualToMessage = "'{0}' phải bằng '{1}'.",
                        IsBetweenInclusiveMessage = "'{0}' phải thuộc đoạn '{1}' và '{2}'.",
                        IsBetweenExclusiveMessage = "'{0}' phải thuộc khoảng '{1}' và '{2}'."
                    };

                default:
                    return Create(LangCode.en);
            }


        }
    }
}
