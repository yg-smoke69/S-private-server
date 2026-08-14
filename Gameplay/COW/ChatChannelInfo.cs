using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002F2D")]
public class ChatChannelInfo
{
	[Token(Token = "0x4012015")]
	[FieldOffset(Offset = "0x8")]
	public EChannel.ChannelType m_ChannelType;

	[Token(Token = "0x4012016")]
	[FieldOffset(Offset = "0x10")]
	public ulong m_ChannelID;

	[Token(Token = "0x6013BB1")]
	[Address(RVA = "0x1722FE4", Offset = "0x1722FE4", VA = "0x1722FE4")]
	public ChatChannelInfo(EChannel.ChannelType type, ulong id)
	{
	}

	[Token(Token = "0x6013BB2")]
	[Address(RVA = "0x1723010", Offset = "0x1723010", VA = "0x1723010", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6013BB3")]
	[Address(RVA = "0x1723130", Offset = "0x1723130", VA = "0x1723130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6013BB4")]
	[Address(RVA = "0x1723194", Offset = "0x1723194", VA = "0x1723194")]
	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return default(bool);
	}

	[Token(Token = "0x6013BB5")]
	[Address(RVA = "0x172319C", Offset = "0x172319C", VA = "0x172319C")]
	public int _003C_003EiFixBaseProxy_GetHashCode()
	{
		return default(int);
	}
}
