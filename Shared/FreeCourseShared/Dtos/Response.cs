using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;

namespace FreeCourseShared.Dtos
{
    public class Response<T>
    {
        public T Data { get;private set; }
        [JsonIgnore]
        public int StatusCode { get;private set; }
        public bool  IsSuccessful { get;private set; }
        public List<string> Errors { get; private set; }
         public static Response<T> Success(T data,int statusCode) 
        {
            return new Response<T> { Data = data, StatusCode = statusCode };
        }
        public static Response<T> Success(int statusCode)
        {
            return new Response<T> { Data = default(T), StatusCode = statusCode, IsSuccessful = true };
        }    
        public static Response<T> Fail(List<string> errors,int statuscode) 
        {
            return new Response<T>
            {
                Errors = errors,
                StatusCode = statuscode,
                IsSuccessful = false

            };
        }
        public static Response<T> Fail(string error,int statusCode)
        {
           return new Response<T> { Errors = new List<string>() { error }, StatusCode = statusCode, IsSuccessful = false };
        }
    }
}
