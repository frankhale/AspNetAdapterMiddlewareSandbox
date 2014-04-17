using AspNetAdapter;
using System;
using System.Collections.Generic;

namespace AspNetAdapterMiddlewareSandbox
{
	public class AppTest : IAspNetAdapterApplication
	{
		public void Init(Dictionary<string, object> app,
										 Dictionary<string, object> request,
										 Action<Dictionary<string, object>> response)
		{
			var responseDict = new Dictionary<string, object>();
			
			if (request.ContainsKey(MiddlewareTestConstants.Test))
			{
				responseDict[HttpAdapterConstants.ResponseBody] = string.Format("<h1>{0}</h1>", request[MiddlewareTestConstants.Test]);
			}
			else
			{
				responseDict[HttpAdapterConstants.ResponseBody] = string.Format("<h1>That didn't work! I couldn't find the middleware key {0}</h1>", MiddlewareTestConstants.Test);
			}
			
			response(responseDict);
		}
	}
}