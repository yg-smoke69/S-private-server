using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A52")]
public class UnlockProfileInfo
{
	[Token(Token = "0x400A4DF")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x400A4E0")]
	[FieldOffset(Offset = "0xC")]
	public uint unlock_level;

	[Token(Token = "0x400A4E1")]
	[FieldOffset(Offset = "0x10")]
	public uint required_level;

	[Token(Token = "0x400A4E2")]
	[FieldOffset(Offset = "0x14")]
	public uint avatar_debris_id;

	[Token(Token = "0x400A4E3")]
	[FieldOffset(Offset = "0x18")]
	public uint avatar_debris_num;

	[Token(Token = "0x400A4E4")]
	[FieldOffset(Offset = "0x1C")]
	public List<AwardDesc> awards;

	[Token(Token = "0x60080AA")]
	[Address(RVA = "0x33E4124", Offset = "0x33E4124", VA = "0x33E4124")]
	public UnlockProfileInfo()
	{
	}
}
