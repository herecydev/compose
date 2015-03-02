﻿using Microsoft.Framework.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Compose
{
	internal class WrappedServiceProvider : RootServiceProvider
	{
		public WrappedServiceProvider(IEnumerable<IServiceDescriptor> services) 
			: base((IServiceProvider)Activator.CreateInstance(Constants.GetServiceProvider(), services)) { }
	}
}
