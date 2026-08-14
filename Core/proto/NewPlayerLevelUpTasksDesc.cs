using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A09")]
public class NewPlayerLevelUpTasksDesc
{
	[Token(Token = "0x400A33B")]
	[FieldOffset(Offset = "0x8")]
	public uint task_id;

	[Token(Token = "0x400A33C")]
	[FieldOffset(Offset = "0xC")]
	public EActivity.ConditionType cdt_type;

	[Token(Token = "0x400A33D")]
	[FieldOffset(Offset = "0x10")]
	public uint cdt_value;

	[Token(Token = "0x400A33E")]
	[FieldOffset(Offset = "0x14")]
	public List<AwardDesc> awards;

	[Token(Token = "0x6008061")]
	[Address(RVA = "0x30A9DEC", Offset = "0x30A9DEC", VA = "0x30A9DEC")]
	public NewPlayerLevelUpTasksDesc()
	{
	}
}
