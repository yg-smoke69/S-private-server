using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A26")]
public class ClanLevelDesc
{
	[Token(Token = "0x400A3D3")]
	[FieldOffset(Offset = "0x8")]
	public uint level;

	[Token(Token = "0x400A3D4")]
	[FieldOffset(Offset = "0xC")]
	public uint min_honor;

	[Token(Token = "0x400A3D5")]
	[FieldOffset(Offset = "0x10")]
	public uint exp_buff_factor;

	[Token(Token = "0x400A3D6")]
	[FieldOffset(Offset = "0x14")]
	public uint gold_buff_factor;

	[Token(Token = "0x400A3D7")]
	[FieldOffset(Offset = "0x18")]
	public uint size_improved;

	[Token(Token = "0x400A3D8")]
	[FieldOffset(Offset = "0x1C")]
	public uint gold_limit_improved;

	[Token(Token = "0x400A3D9")]
	[FieldOffset(Offset = "0x20")]
	public List<AwardDesc> awards;

	[Token(Token = "0x600807E")]
	[Address(RVA = "0x309BC00", Offset = "0x309BC00", VA = "0x309BC00")]
	public ClanLevelDesc()
	{
	}
}
