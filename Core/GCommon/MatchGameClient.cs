using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200405E")]
internal class MatchGameClient : NetworkClient, _Attribute
{
	[Token(Token = "0x401B16A")]
	[FieldOffset(Offset = "0x10")]
	protected UDPSession m_UDPSession;

	[Token(Token = "0x401B16B")]
	[FieldOffset(Offset = "0x14")]
	protected MemoryStream m_SendMemoryStream;

	[Token(Token = "0x401B16C")]
	[FieldOffset(Offset = "0x18")]
	protected MemoryStream m_RecvMemoryStream;

	[Token(Token = "0x401B16D")]
	[FieldOffset(Offset = "0x1C")]
	protected FastBinaryReader m_BinaryReader;

	[Token(Token = "0x401B16E")]
	[FieldOffset(Offset = "0x20")]
	protected FastBinaryWriter m_BinaryWriter;

	[Token(Token = "0x401B16F")]
	[FieldOffset(Offset = "0x24")]
	protected Queue<UDPMsgPacket> m_RecvUDPMsgList;

	[Token(Token = "0x401B170")]
	[FieldOffset(Offset = "0x28")]
	protected ISessionHanlder m_SessionHandler;

	[Token(Token = "0x401B171")]
	[FieldOffset(Offset = "0x2C")]
	protected float m_LastRecvPingPacketTime;

	[Token(Token = "0x601A341")]
	[Address(RVA = "0x2968D10", Offset = "0x2968D10", VA = "0x2968D10")]
	public MatchGameClient(ISessionHanlder sessionHanlder)
	{
	}

	[Token(Token = "0x601A342")]
	[Address(RVA = "0x2968E90", Offset = "0x2968E90", VA = "0x2968E90", Slot = "7")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x601A343")]
	[Address(RVA = "0x29690C0", Offset = "0x29690C0", VA = "0x29690C0", Slot = "8")]
	public virtual bool Send(uint messageID, UDPClientMessageBase msg, byte sendOption = 0, bool cacheMsgAnyWay = false)
	{
		return default(bool);
	}

	[Token(Token = "0x601A344")]
	[Address(RVA = "0x29695F8", Offset = "0x29695F8", VA = "0x29695F8", Slot = "9")]
	public virtual void OnConnected(bool result)
	{
	}

	[Token(Token = "0x601A345")]
	[Address(RVA = "0x2969828", Offset = "0x2969828", VA = "0x2969828", Slot = "10")]
	public virtual void OnDisconnected(DisconnectedReason reason)
	{
	}

	[Token(Token = "0x601A346")]
	[Address(RVA = "0x2969948", Offset = "0x2969948", VA = "0x2969948", Slot = "11")]
	public virtual void OnPingSent(int lastSentTime)
	{
	}

	[Token(Token = "0x601A347")]
	[Address(RVA = "0x2969A24", Offset = "0x2969A24", VA = "0x2969A24", Slot = "12")]
	protected virtual void HandleRecvPacket()
	{
	}
}
