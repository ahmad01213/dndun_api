using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Options;

namespace dndun_solution.Data.Base.ResponseBase
{
   internal class ResponseEnvelopeResultExecutor : ObjectResultExecutor
{
 public ResponseEnvelopeResultExecutor(OutputFormatterSelector formatterSelector, IHttpResponseStreamWriterFactory writerFactory, ILoggerFactory loggerFactory, IOptions<MvcOptions> mvcOptions) : base(formatterSelector, writerFactory, loggerFactory, mvcOptions)
 {
 }

 public override Task ExecuteAsync(ActionContext context, ObjectResult result)
 {
     var response = new ResponseEnvelope<object>();
     response.Data = result.Value;
     response.Code = result.StatusCode ?? 0;
     response.Status = result?.StatusCode==200?true:false;
     response.Message = result?.StatusCode==200?"Success":result?.StatusCode==500?"Internal Server Error":"Error";

     TypeCode typeCode = Type.GetTypeCode(result.Value.GetType());
     if (typeCode == TypeCode.Object)
          result.Value = response;

     return base.ExecuteAsync(context, result);
  }
}
}