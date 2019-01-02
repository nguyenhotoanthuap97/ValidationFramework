using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.Message
{
    public class VietnameseMessagesContainer: MessagesContainer
    {
        public VietnameseMessagesContainer()
        {
            IsNotNullMessage = "'{0}' không được phép null.";
            IsNotNullOrEmptyMessage = "'{0}' không được phép rỗng hay null .";
            IsNotNullOrWhiteSpaceMessage = "'{0}'  không được phép null hay chỉ chứa khoảng trắng.";
            IsNotZeroMessage = "'{0}' không thể bằng 0.";
            IsPasswordMessage = "'{0}' không phải mật khẩu. Mật khảu phải từ 8 đến 30 kí tự, ít nhất một chữ hoa, một chữ thường và một số.";
            IsMinLengthMessage = "'{0}' phải ít nhất có {1} kí tự.";
            IsMaxLengthMessage = "'{0}' phải có nhiều nhất {1} kí tự.";
            IsExactLengthMessage = "'{0}' phải có đúng {1} kí tự";
            IsBetweenLengthMessage = "'{0}' phải có ít nhất {1} và nhiều nhất {2} kí tự.";
            IsMessage = "'{0}' không thỏa điều kiện.";
            IsNotMessage = "'{0}' không thỏa điều kiện.";
            IsEmailMessage = "'{0}' không phải email.";
            IsRegexMessage = "'{0}' không thỏa biểu thức chính quy cho trước.";
            IsMatchMessage = "'{0}' không thỏa điều kiện.";
            IsDateMessage = "'{0}' không phải ngày hợp lệ.";
            IsRuleMessage = "'{0}' failed the provided business rule provided.";
            IsGreaterThanMessage = "'{0}' phải lớn hơn '{1}'.";
            IsGreaterThanOrEqualToMessage = "'{0}' phải lớn hơn hoặc bằng '{1}'.";
            IsLessThanMessage = "'{0}' phải nhỏ hơn '{1}'.";
            IsLessThanOrEqualToMessage = "'{0}' phải nhỏ hơn hoặc bằng '{1}'.";
            IsEqualToMessage = "'{0}' phải bằng '{1}'.";
            IsBetweenInclusiveMessage = "'{0}' phải thuộc đoạn '{1}' và '{2}'.";
            IsBetweenExclusiveMessage = "'{0}' phải thuộc khoảng '{1}' và '{2}'.";             
        }
    }
}
