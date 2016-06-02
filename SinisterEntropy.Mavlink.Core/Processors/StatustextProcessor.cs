using MavLinkNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinisterEntropy.Mavlink.Core.Processors
{
	public class StatustextProcessor : MessageProcessorBase<UasStatustext>
	{
		public StatustextProcessor(NLog.ILogger logger)
			: base(logger)
		{ }

		protected override void ProcessInternal(UasStatustext message)
		{
			base.ProcessInternal(message);
		}

		protected override void Log(UasStatustext message)
		{
			if (_logger != null)
			{
				_logger.Debug("Processing Status Text: {0}.  Text: {1}. Severity {2}.", message.MessageId, new string(message.Text), message.Severity);
			}
		}
	}
}
