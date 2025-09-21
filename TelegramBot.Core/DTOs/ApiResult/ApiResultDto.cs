using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot.Core.DTOs.ApiResult
{
    public class ApiResultDto<T>
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }

        public int ResponseCode { get; set; }


        public static ApiResultDto<T> CreateSuccess<T>(T data, bool IsSuccess = true, string Message = "عملیات با موفقیت انجام شد.")
        {
            return new ApiResultDto<T>() { Data = data, IsSuccess = IsSuccess, Message = Message, ResponseCode = (int)ResultRsCode.Success };
        }

        public enum ResultRsCode
        {
            Success = 00,
        }
    }
}
