using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BD6")]
public class WorkshopSwitchDesc
{
	[Token(Token = "0x400AF1D")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400AF1E")]
	[FieldOffset(Offset = "0xC")]
	public bool type_switch1;

	[Token(Token = "0x400AF1F")]
	[FieldOffset(Offset = "0xD")]
	public bool type_switch2;

	[Token(Token = "0x400AF20")]
	[FieldOffset(Offset = "0xE")]
	public bool type_switch3;

	[Token(Token = "0x400AF21")]
	[FieldOffset(Offset = "0xF")]
	public bool type_switch4;

	[Token(Token = "0x6008231")]
	[Address(RVA = "0x33E6AE8", Offset = "0x33E6AE8", VA = "0x33E6AE8")]
	public WorkshopSwitchDesc()
	{
	}
}
