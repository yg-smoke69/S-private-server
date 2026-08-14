using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B39")]
public class AnniversaryNodeDesc
{
	[Token(Token = "0x400AB31")]
	[FieldOffset(Offset = "0x8")]
	public uint node_id;

	[Token(Token = "0x400AB32")]
	[FieldOffset(Offset = "0xC")]
	public ELimitedEvent.NodeStatus status;

	[Token(Token = "0x400AB33")]
	[FieldOffset(Offset = "0x10")]
	public uint sub_node;

	[Token(Token = "0x400AB34")]
	[FieldOffset(Offset = "0x18")]
	public ulong unlock_amount;

	[Token(Token = "0x400AB35")]
	[FieldOffset(Offset = "0x20")]
	public ulong unlock_single;

	[Token(Token = "0x400AB36")]
	[FieldOffset(Offset = "0x28")]
	public List<AwardDesc> award_items;

	[Token(Token = "0x400AB37")]
	[FieldOffset(Offset = "0x2C")]
	public uint node_type;

	[Token(Token = "0x6008194")]
	[Address(RVA = "0x317A844", Offset = "0x317A844", VA = "0x317A844")]
	public AnniversaryNodeDesc()
	{
	}
}
