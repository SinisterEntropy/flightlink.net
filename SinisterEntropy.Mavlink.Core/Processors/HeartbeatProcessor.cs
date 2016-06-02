using MavLinkNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinisterEntropy.Mavlink.Core.Processors
{
	public class HeartbeatProcessor : MessageProcessorBase<UasHeartbeat>
	{
		public HeartbeatProcessor(NLog.ILogger logger)
			: base(logger)
		{ }

		protected override void ProcessInternal(UasHeartbeat message)
		{
			base.ProcessInternal(message);
		}

		protected override void Log(UasHeartbeat message)
		{
			if (_logger != null)
			{
				_logger.Debug("Processing Heartbeat: {0}.  System Status: {1}. Version {2}.", message.MessageId, message.SystemStatus, message.MavlinkVersion);
			}
		}
	}
}
