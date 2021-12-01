using System;
using System.Collections.Generic;

namespace Common
{
    public class OperationResult<T>
    {
        public OperationResult()
        {
            Message = new List<string>();
        }

        public T ObjResult { get; set; }

        public bool Success { get; set; }
        public List<string> Message { get; set; }


    }
}
