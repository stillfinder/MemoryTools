using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memory
{
	class ReadMemoryException : Exception
	{
		public ReadMemoryException()
			: base()
		{
		}

		public ReadMemoryException(string message)
			: base(message)
		{
		}
	}
}
