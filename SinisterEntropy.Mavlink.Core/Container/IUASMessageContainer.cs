using MavLinkNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinisterEntropy.Mavlink.Core.Container
{
	public interface IUasMessageContainer
	{
		void Initialize();

		IMessageProcessor<M> GetMessageProcessor<M>()
			where M : UasMessage;
	}
}
