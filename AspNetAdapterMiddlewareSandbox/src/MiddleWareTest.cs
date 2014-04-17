//
// A very simple middleware that adds a new key to the request dictionary
// 

using System.Collections.Generic;
using AspNetAdapter;

namespace AspNetAdapterMiddlewareSandbox
{
	public static class MiddlewareTestConstants
	{
		public static readonly string Test = "Test";
	}

	public class MiddleWareTest : IAspNetAdapterMiddleware
	{
		public MiddlewareResult Transform(Dictionary<string, object> app,
																			Dictionary<string, object> request)
		{
			request[MiddlewareTestConstants.Test] = "Hello, World";

			return new MiddlewareResult { App = app, Request = request };
		}
	}
}