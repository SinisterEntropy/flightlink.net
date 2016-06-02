using MavLinkNet;
using SinisterEntropy.Mavlink.Core.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTest
{
	class Program
	{
		static IUasMessageContainer container = new DefaultUasMessageContainer();
		static int count = 0;

		static void Main(string[] args)
		{
			container.Initialize();

			string fileName = @"F:\Downloads\2016-02-26 11-16-35.tlog";
			using(MavLinkLogFileTransport logReader = new MavLinkLogFileTransport(fileName))
			{
				logReader.OnPacketReceived += logReader_OnPacketReceived;
				logReader.Initialize();
			}

			Console.WriteLine("Done {0}.", count);
			Console.ReadLine();
		}

		static void logReader_OnPacketReceived(object sender, MavLinkPacket packet)
		{
			count++;
			if (packet.Message is UasHeartbeat)
			{
				IMessageProcessor<UasHeartbeat> heartbeatProcessor = container.GetMessageProcessor<UasHeartbeat>();
				if (heartbeatProcessor != null)
				{
					heartbeatProcessor.Process((UasHeartbeat)packet.Message);
				}
				else
				{
					Console.WriteLine("Heartbeat: {0}", ((UasHeartbeat)packet.Message).Type);
				}
			}
			else if(packet.Message is UasBatteryStatus)
			{
				IMessageProcessor<UasBatteryStatus> processor = container.GetMessageProcessor<UasBatteryStatus>();
				if (processor != null)
				{
					processor.Process((UasBatteryStatus)packet.Message);
				}
				else
				{
					Console.WriteLine("Battery: {0}", ((UasBatteryStatus)packet.Message).CurrentBattery);
				}
			}
			else if(packet.Message is UasGpsStatus)
			{
				Console.WriteLine("GPS Status: {0}", ((UasGpsStatus)packet.Message).SatellitesVisible);
			}
			else if (packet.Message is UasStatustext)
			{
				IMessageProcessor<UasStatustext> processor = container.GetMessageProcessor<UasStatustext>();
				if (processor != null)
				{
					processor.Process((UasStatustext)packet.Message);
				}
				else
				{
					Console.WriteLine("Status: {0}", new string(((UasStatustext)packet.Message).Text));
				}
			}
			else
			{
				Console.WriteLine("Type: {0}, ID: {1}", packet.Message.GetType().Name, packet.Message.MessageId);
			}
		}
	}
}
