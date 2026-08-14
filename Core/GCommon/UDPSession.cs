using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using ICSharpCode.SharpZipLib.GZip;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040AA")]
public class UDPSession : NetworkSession
{
	[Token(Token = "0x20040AB")]
	private class HelloData
	{
		[Token(Token = "0x401B2C1")]
		[FieldOffset(Offset = "0x8")]
		public bool HasNewConnectionResponse;

		[Token(Token = "0x401B2C2")]
		[FieldOffset(Offset = "0xC")]
		public UDPMessageIDReserved Cmd;

		[Token(Token = "0x401B2C3")]
		[FieldOffset(Offset = "0x10")]
		public string SessionKey;

		[Token(Token = "0x601A50C")]
		[Address(RVA = "0x32474A8", Offset = "0x32474A8", VA = "0x32474A8")]
		public HelloData()
		{
		}
	}

	[Token(Token = "0x401B29A")]
	[FieldOffset(Offset = "0x0")]
	public static bool UseTCPMode;

	[Token(Token = "0x401B29B")]
	private const int RECV_BUFF_SIZE = 512000;

	[Token(Token = "0x401B29C")]
	private const int SEND_BUFF_SIZE = 128000;

	[Token(Token = "0x401B29D")]
	[FieldOffset(Offset = "0x38")]
	private SocketClient m_UDPConnetion;

	[Token(Token = "0x401B29E")]
	[FieldOffset(Offset = "0x3C")]
	private IPEndPoint m_IPEndPoint;

	[Token(Token = "0x401B29F")]
	[FieldOffset(Offset = "0x40")]
	private Thread m_KeepAliveThread;

	[Token(Token = "0x401B2A0")]
	[FieldOffset(Offset = "0x44")]
	private AutoResetEvent m_KeepAliveSignalEvent;

	[Token(Token = "0x401B2A1")]
	[FieldOffset(Offset = "0x48")]
	private NetworkByteStream m_RecvBuffer;

	[Token(Token = "0x401B2A2")]
	[FieldOffset(Offset = "0x4C")]
	private MemoryStream m_RecvMemoryStream;

	[Token(Token = "0x401B2A3")]
	[FieldOffset(Offset = "0x50")]
	private Queue<UDPMsgPacket> m_RecvPacketQueue;

	[Token(Token = "0x401B2A4")]
	[FieldOffset(Offset = "0x54")]
	private LinkedList<UDPMsgPacket> m_PendingReliableRecvPacket;

	[Token(Token = "0x401B2A5")]
	[FieldOffset(Offset = "0x58")]
	private object m_HelloPacketLock;

	[Token(Token = "0x401B2A6")]
	[FieldOffset(Offset = "0x5C")]
	private HelloData m_HelloPacket;

	[Token(Token = "0x401B2A7")]
	[FieldOffset(Offset = "0x60")]
	private Queue<UDPMsgPacket> m_SendPacketQueue;

	[Token(Token = "0x401B2A8")]
	[FieldOffset(Offset = "0x68")]
	private double m_KeepAliveInterval;

	[Token(Token = "0x401B2A9")]
	[FieldOffset(Offset = "0x70")]
	private double m_LastKeepAliveTime;

	[Token(Token = "0x401B2AA")]
	[FieldOffset(Offset = "0x78")]
	private MemoryStream m_PingStream;

	[Token(Token = "0x401B2AB")]
	[FieldOffset(Offset = "0x7C")]
	private FastBinaryWriter m_PingBinaryWriter;

	[Token(Token = "0x401B2AC")]
	[FieldOffset(Offset = "0x80")]
	private C2S_UDP_Ping_Req m_PingKeepAliveMsg;

	[Token(Token = "0x401B2AD")]
	[FieldOffset(Offset = "0x88")]
	private double m_MaxDeactiveTime;

	[Token(Token = "0x401B2AE")]
	[FieldOffset(Offset = "0x90")]
	private object m_LastAliveTimeLock;

	[Token(Token = "0x401B2AF")]
	[FieldOffset(Offset = "0x98")]
	private double m_LastAliveTime;

	[Token(Token = "0x401B2B0")]
	[FieldOffset(Offset = "0xA0")]
	private UDPReliableTracking m_ReliableTracking;

	[Token(Token = "0x401B2B1")]
	[FieldOffset(Offset = "0xA4")]
	private List<UDPMsgPacket> m_PacketToResend;

	[Token(Token = "0x401B2B2")]
	[FieldOffset(Offset = "0xA8")]
	private object m_SocketExceptionLock;

	[Token(Token = "0x401B2B3")]
	[FieldOffset(Offset = "0xAC")]
	private bool m_IsSocketRaiseException;

	[Token(Token = "0x401B2B4")]
	[FieldOffset(Offset = "0xAD")]
	private bool m_NeedReconnectFlag;

	[Token(Token = "0x401B2B5")]
	[FieldOffset(Offset = "0xB0")]
	private double m_ReconnectEndTime;

	[Token(Token = "0x401B2B6")]
	[FieldOffset(Offset = "0xB8")]
	private string m_SessionKey;

	[Token(Token = "0x401B2B7")]
	[FieldOffset(Offset = "0xBC")]
	private bool m_HasConnected;

	[Token(Token = "0x401B2B8")]
	[FieldOffset(Offset = "0xC0")]
	private uint m_NextTrackingID;

	[Token(Token = "0x401B2B9")]
	[FieldOffset(Offset = "0x1")]
	public static bool DebugDropAll;

	[Token(Token = "0x401B2BA")]
	[FieldOffset(Offset = "0xC4")]
	private byte[] m_DecTempBuffer;

	[Token(Token = "0x401B2BB")]
	[FieldOffset(Offset = "0xC8")]
	private TeaDecTempBuffer m_DecBuffer;

	[Token(Token = "0x401B2BC")]
	[FieldOffset(Offset = "0xCC")]
	private byte[] m_EncTempBuffer;

	[Token(Token = "0x401B2BD")]
	[FieldOffset(Offset = "0xD0")]
	private TeaEncTempBuffer m_EncBuffer;

	[Token(Token = "0x401B2BE")]
	[FieldOffset(Offset = "0xD4")]
	private byte[] m_ZipWorkingBuffer;

	[Token(Token = "0x401B2BF")]
	[FieldOffset(Offset = "0xD8")]
	private byte[] m_ZipOutputBuffer;

	[Token(Token = "0x401B2C0")]
	[FieldOffset(Offset = "0xDC")]
	private GZipInputStream m_GZipInputStream;

	[Token(Token = "0x17001CC9")]
	public byte[] DecTempBuffer
	{
		[Token(Token = "0x601A4F0")]
		[Address(RVA = "0x3244358", Offset = "0x3244358", VA = "0x3244358")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CCA")]
	public TeaDecTempBuffer DecBuffer
	{
		[Token(Token = "0x601A4F1")]
		[Address(RVA = "0x3244350", Offset = "0x3244350", VA = "0x3244350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CCB")]
	public byte[] EncTempBuffer
	{
		[Token(Token = "0x601A4F2")]
		[Address(RVA = "0x3244894", Offset = "0x3244894", VA = "0x3244894")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CCC")]
	public TeaEncTempBuffer EncBuffer
	{
		[Token(Token = "0x601A4F3")]
		[Address(RVA = "0x324488C", Offset = "0x324488C", VA = "0x324488C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CCD")]
	public byte[] ZipWorkingBuffer
	{
		[Token(Token = "0x601A4F4")]
		[Address(RVA = "0x324429C", Offset = "0x324429C", VA = "0x324429C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CCE")]
	public byte[] ZipOutputBuffer
	{
		[Token(Token = "0x601A4F5")]
		[Address(RVA = "0x32441E8", Offset = "0x32441E8", VA = "0x32441E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CCF")]
	public GZipInputStream GZipInputStream
	{
		[Token(Token = "0x601A4F6")]
		[Address(RVA = "0x3244144", Offset = "0x3244144", VA = "0x3244144")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A4EF")]
	[Address(RVA = "0x32471F4", Offset = "0x32471F4", VA = "0x32471F4")]
	public UDPSession([Optional] ISessionHanlder cb)
	{
	}

	[Token(Token = "0x601A4F7")]
	[Address(RVA = "0x32474B0", Offset = "0x32474B0", VA = "0x32474B0", Slot = "4")]
	public override bool IsConnected()
	{
		return default(bool);
	}

	[Token(Token = "0x601A4F8")]
	[Address(RVA = "0x32474E8", Offset = "0x32474E8", VA = "0x32474E8")]
	private bool CreateAndConnectSocket(IPEndPoint endPoint, bool isReconnect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x601A4F9")]
	[Address(RVA = "0x32476A0", Offset = "0x32476A0", VA = "0x32476A0")]
	public void ForceToRecconnect()
	{
	}

	[Token(Token = "0x601A4FA")]
	[Address(RVA = "0x32476D4", Offset = "0x32476D4", VA = "0x32476D4")]
	private bool CheckReconnect()
	{
		return default(bool);
	}

	[Token(Token = "0x601A4FB")]
	[Address(RVA = "0x3247874", Offset = "0x3247874", VA = "0x3247874")]
	private void InvokeConnectionResult()
	{
	}

	[Token(Token = "0x601A4FC")]
	[Address(RVA = "0x3247960", Offset = "0x3247960", VA = "0x3247960")]
	private void UpdateSessionKey(string key)
	{
	}

	[Token(Token = "0x601A4FD")]
	[Address(RVA = "0x3247A40", Offset = "0x3247A40", VA = "0x3247A40", Slot = "5")]
	protected override bool OnConnect(string serverAddr, int port)
	{
		return default(bool);
	}

	[Token(Token = "0x601A4FE")]
	[Address(RVA = "0x32482A0", Offset = "0x32482A0", VA = "0x32482A0")]
	private void UpdateKeepAlive()
	{
	}

	[Token(Token = "0x601A4FF")]
	[Address(RVA = "0x324851C", Offset = "0x324851C", VA = "0x324851C", Slot = "6")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x601A500")]
	[Address(RVA = "0x3249048", Offset = "0x3249048", VA = "0x3249048", Slot = "7")]
	protected override void OnClose()
	{
	}

	[Token(Token = "0x601A501")]
	[Address(RVA = "0x3247FE4", Offset = "0x3247FE4", VA = "0x3247FE4")]
	public void Send(uint cmd, byte[] data, int byteCount, byte sendOption = 0)
	{
	}

	[Token(Token = "0x601A502")]
	[Address(RVA = "0x3248D74", Offset = "0x3248D74", VA = "0x3248D74")]
	public void Resend(List<UDPMsgPacket> packets)
	{
	}

	[Token(Token = "0x601A503")]
	[Address(RVA = "0x3249228", Offset = "0x3249228", VA = "0x3249228")]
	public void GetUDPPackets(Queue<UDPMsgPacket> outPackets)
	{
	}

	[Token(Token = "0x601A504")]
	[Address(RVA = "0x3249388", Offset = "0x3249388", VA = "0x3249388")]
	public void SetKeepAliveInterval(double interval)
	{
	}

	[Token(Token = "0x601A505")]
	[Address(RVA = "0x3247EAC", Offset = "0x3247EAC", VA = "0x3247EAC")]
	private void CreateKeepAliveThread()
	{
	}

	[Token(Token = "0x601A506")]
	[Address(RVA = "0x3249398", Offset = "0x3249398", VA = "0x3249398")]
	private void OnRecvDataThreadNoSleep()
	{
	}

	[Token(Token = "0x601A507")]
	[Address(RVA = "0x324B288", Offset = "0x324B288", VA = "0x324B288")]
	private void OnRecvDataThread()
	{
	}

	[Token(Token = "0x601A508")]
	[Address(RVA = "0x3249AF0", Offset = "0x3249AF0", VA = "0x3249AF0")]
	private void HandleRecv(BinaryReader binaryReader)
	{
	}

	[Token(Token = "0x601A509")]
	[Address(RVA = "0x324BAFC", Offset = "0x324BAFC", VA = "0x324BAFC")]
	private void OnSendDataThread()
	{
	}

	[Token(Token = "0x601A50A")]
	[Address(RVA = "0x324CAF4", Offset = "0x324CAF4", VA = "0x324CAF4")]
	private void OnKeepAliveThread()
	{
	}
}
