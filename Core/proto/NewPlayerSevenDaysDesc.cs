using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B08")]
public class NewPlayerSevenDaysDesc
{
	[Token(Token = "0x400A9F4")]
	[FieldOffset(Offset = "0x8")]
	public uint achievement_id;

	[Token(Token = "0x400A9F5")]
	[FieldOffset(Offset = "0xC")]
	public EActivity.PreConditionType pre_cdt_type1;

	[Token(Token = "0x400A9F6")]
	[FieldOffset(Offset = "0x10")]
	public uint[] pre_cdt_value1;

	[Token(Token = "0x400A9F7")]
	[FieldOffset(Offset = "0x14")]
	public EActivity.PreConditionType pre_cdt_type2;

	[Token(Token = "0x400A9F8")]
	[FieldOffset(Offset = "0x18")]
	public uint[] pre_cdt_value2;

	[Token(Token = "0x400A9F9")]
	[FieldOffset(Offset = "0x1C")]
	public EActivity.PreConditionType pre_cdt_type3;

	[Token(Token = "0x400A9FA")]
	[FieldOffset(Offset = "0x20")]
	public uint[] pre_cdt_value3;

	[Token(Token = "0x400A9FB")]
	[FieldOffset(Offset = "0x24")]
	public EActivity.PreConditionType pre_cdt_type4;

	[Token(Token = "0x400A9FC")]
	[FieldOffset(Offset = "0x28")]
	public uint[] pre_cdt_value4;

	[Token(Token = "0x400A9FD")]
	[FieldOffset(Offset = "0x2C")]
	public EActivity.PreConditionType pre_cdt_type5;

	[Token(Token = "0x400A9FE")]
	[FieldOffset(Offset = "0x30")]
	public uint[] pre_cdt_value5;

	[Token(Token = "0x400A9FF")]
	[FieldOffset(Offset = "0x34")]
	public EActivity.ConditionType cdt_type;

	[Token(Token = "0x400AA00")]
	[FieldOffset(Offset = "0x38")]
	public uint cdt_value;

	[Token(Token = "0x400AA01")]
	[FieldOffset(Offset = "0x3C")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400AA02")]
	[FieldOffset(Offset = "0x40")]
	public uint pre_cdt_switch;

	[Token(Token = "0x6008163")]
	[Address(RVA = "0x33DE750", Offset = "0x33DE750", VA = "0x33DE750")]
	public NewPlayerSevenDaysDesc()
	{
	}
}
