using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001513")]
public class CSSendMatchLikeInfoReq
{
	[Token(Token = "0x40090A5")]
	[FieldOffset(Offset = "0x8")]
	public ulong match_id;

	[Token(Token = "0x40090A6")]
	[FieldOffset(Offset = "0x10")]
	public uint game_mode;

	[Token(Token = "0x40090A7")]
	[FieldOffset(Offset = "0x14")]
	public uint match_mode;

	[Token(Token = "0x40090A8")]
	[FieldOffset(Offset = "0x18")]
	public List<LikeReceiverInfo> like_receiver_list;

	[Token(Token = "0x6007B5C")]
	[Address(RVA = "0x309982C", Offset = "0x309982C", VA = "0x309982C")]
	public CSSendMatchLikeInfoReq()
	{
	}
}
