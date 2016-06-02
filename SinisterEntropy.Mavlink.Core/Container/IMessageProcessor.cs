using MavLinkNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinisterEntropy.Mavlink.Core.Container
{
	public interface IMessageProcessor<M> where M : UasMessage
	{
		void Process(M message);
	}
}
