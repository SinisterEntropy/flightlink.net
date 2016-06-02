using MavLinkNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinisterEntropy.Mavlink.Core.Processors
{
	public class BatteryStatusProcessor : MessageProcessorBase<UasBatteryStatus>
	{
		public BatteryStatusProcessor(NLog.ILogger logger)
			: base(logger)
		{ }

		protected override void ProcessInternal(UasBatteryStatus message)
		{
			base.ProcessInternal(message);
		}

		protected override void Log(UasBatteryStatus message)
		{
			if (_logger != null)
			{
				_logger.Debug("Processing Battery Status: {0}.  Current Battery: {1}. Remaining Battery {2}.", message.MessageId, message.CurrentBattery, message.BatteryRemaining);
			}
		}
	}
}
