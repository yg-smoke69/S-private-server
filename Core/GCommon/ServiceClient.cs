using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200408C")]
internal class ServiceClient : NetworkClient, _Attribute
{
	[Token(Token = "0x401B20C")]
	[FieldOffset(Offset = "0x10")]
	private TCPSession m_TCPSession;

	[Token(Token = "0x401B20D")]
	[FieldOffset(Offset = "0x14")]
	private Queue<TCPMsgPacket> m_RecvTCPMsgList;

	[Token(Token = "0x401B20E")]
	[FieldOffset(Offset = "0x18")]
	private ISessionHanlder m_SessionHandler;

	[Token(Token = "0x601A46D")]
	[Address(RVA = "0x32310C8", Offset = "0x32310C8", VA = "0x32310C8")]
	public ServiceClient(string token, ISessionHanlder sessionHanlder)
	{
	}

	[Token(Token = "0x601A46E")]
	[Address(RVA = "0x3231344", Offset = "0x3231344", VA = "0x3231344")]
	public void Update()
	{
	}

	[Token(Token = "0x601A46F")]
	[Address(RVA = "0x3231B2C", Offset = "0x3231B2C", VA = "0x3231B2C")]
	public bool Send(byte cmd, byte[] data, int byteCount, byte region)
	{
		return default(bool);
	}

	[Token(Token = "0x601A470")]
	[Address(RVA = "0x3231E28", Offset = "0x3231E28", VA = "0x3231E28", Slot = "4")]
	public void OnConnected(bool result)
	{
	}

	[Token(Token = "0x601A471")]
	[Address(RVA = "0x3231FAC", Offset = "0x3231FAC", VA = "0x3231FAC", Slot = "5")]
	public void OnDisconnected(DisconnectedReason reason)
	{
	}

	[Token(Token = "0x601A472")]
	[Address(RVA = "0x32320CC", Offset = "0x32320CC", VA = "0x32320CC", Slot = "6")]
	public void OnPingSent(int lastSentTime)
	{
	}

	[Token(Token = "0x601A473")]
	[Address(RVA = "0x32313AC", Offset = "0x32313AC", VA = "0x32313AC")]
	private void HandleRecvPacket()
	{
	}

	[Token(Token = "0x601A474")]
	[Address(RVA = "0x3232310", Offset = "0x3232310", VA = "0x3232310")]
	public void OnApplicationPause(bool paused)
	{
	}
}
