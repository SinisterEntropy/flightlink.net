using MavLinkNet;
using SimpleInjector;
using SinisterEntropy.Mavlink.Core.Logging;
using SinisterEntropy.Mavlink.Core.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinisterEntropy.Mavlink.Core.Container
{
	public class DefaultUasMessageContainer : IUasMessageContainer
	{
		SimpleInjector.Container messageContainer = null;

		public void Initialize()
		{
			messageContainer = new SimpleInjector.Container();

			messageContainer.Register<NLog.ILogger, LoggingCommand>(Lifestyle.Singleton);
			messageContainer.Register<IMessageProcessor<UasHeartbeat>, HeartbeatProcessor>(Lifestyle.Singleton);
			messageContainer.Register<IMessageProcessor<UasBatteryStatus>, BatteryStatusProcessor>(Lifestyle.Singleton);
			messageContainer.Register<IMessageProcessor<UasStatustext>, StatustextProcessor>(Lifestyle.Singleton);
		}


		public IMessageProcessor<M> GetMessageProcessor<M>()
			where M : UasMessage
		{
			return messageContainer.GetInstance<IMessageProcessor<M>>();
		}
	}
}
