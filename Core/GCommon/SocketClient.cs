using System.Net;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040A9")]
public class SocketClient
{
	[Token(Token = "0x401B294")]
	private const int RECV_BUFF_SIZE = 512000;

	[Token(Token = "0x401B295")]
	private const int SEND_BUFF_SIZE = 128000;

	[Token(Token = "0x401B296")]
	[FieldOffset(Offset = "0x8")]
	private UdpClient m_UDPClient;

	[Token(Token = "0x401B297")]
	[FieldOffset(Offset = "0xC")]
	private TcpClient m_TCPClient;

	[Token(Token = "0x401B298")]
	[FieldOffset(Offset = "0x10")]
	private bool useUDP;

	[Token(Token = "0x401B299")]
	[FieldOffset(Offset = "0x14")]
	private byte[] m_TCPSendBuffer;

	[Token(Token = "0x17001CC7")]
	public SocketClient Client
	{
		[Token(Token = "0x601A4EA")]
		[Address(RVA = "0x323517C", Offset = "0x323517C", VA = "0x323517C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CC8")]
	public int Available
	{
		[Token(Token = "0x601A4EB")]
		[Address(RVA = "0x3235180", Offset = "0x3235180", VA = "0x3235180")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x601A4E7")]
	[Address(RVA = "0x32348B8", Offset = "0x32348B8", VA = "0x32348B8")]
	public SocketClient(bool udp = true)
	{
	}

	[Token(Token = "0x601A4E8")]
	[Address(RVA = "0x3234988", Offset = "0x3234988", VA = "0x3234988")]
	public bool Connect(IPEndPoint endPoint)
	{
		return default(bool);
	}

	[Token(Token = "0x601A4E9")]
	[Address(RVA = "0x3235148", Offset = "0x3235148", VA = "0x3235148")]
	public void Close()
	{
	}

	[Token(Token = "0x601A4EC")]
	[Address(RVA = "0x32351B0", Offset = "0x32351B0", VA = "0x32351B0")]
	public Socket Socket()
	{
		return null;
	}

	[Token(Token = "0x601A4ED")]
	[Address(RVA = "0x323520C", Offset = "0x323520C", VA = "0x323520C")]
	public int Receive(byte[] buffer)
	{
		return default(int);
	}

	[Token(Token = "0x601A4EE")]
	[Address(RVA = "0x32353BC", Offset = "0x32353BC", VA = "0x32353BC")]
	public void Send(byte[] buffer, int len)
	{
	}
}
