using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B95")]
public class FFWSTargetDesc
{
	[Token(Token = "0x400AD7D")]
	[FieldOffset(Offset = "0x8")]
	public EMiniGame.FFWS03ManagerStageType stage_type;

	[Token(Token = "0x400AD7E")]
	[FieldOffset(Offset = "0xC")]
	public uint target;

	[Token(Token = "0x400AD7F")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400AD80")]
	[FieldOffset(Offset = "0x14")]
	public uint pre_target;

	[Token(Token = "0x400AD81")]
	[FieldOffset(Offset = "0x18")]
	public string key;

	[Token(Token = "0x60081F0")]
	[Address(RVA = "0x30A07D0", Offset = "0x30A07D0", VA = "0x30A07D0")]
	public FFWSTargetDesc()
	{
	}
}
