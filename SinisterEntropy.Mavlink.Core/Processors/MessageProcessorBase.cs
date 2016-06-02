using MavLinkNet;
using SinisterEntropy.Mavlink.Core.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinisterEntropy.Mavlink.Core.Processors
{
	public class MessageProcessorBase<Message> : IMessageProcessor<Message>
		where Message : UasMessage
	{
		protected NLog.ILogger _logger = null;

		public MessageProcessorBase(NLog.ILogger logger)
		{
			_logger = logger;
		}

		public void Process(Message message)
		{
			Log(message);
			ProcessInternal(message);
		}

		protected virtual void ProcessInternal(Message message)
		{

		}

		protected virtual void Log(Message message)
		{
			if (_logger != null)
			{
				_logger.Debug("Processing Message: {0}.  CrcExtra: {1}. Version {2}.", message.MessageId, message.CrcExtra);
			}
		}
	}
}
