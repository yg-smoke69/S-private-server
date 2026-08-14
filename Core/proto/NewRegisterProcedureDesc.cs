using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B0E")]
public class NewRegisterProcedureDesc
{
	[Token(Token = "0x400AA12")]
	[FieldOffset(Offset = "0x8")]
	public bool is_new_procedure_open;

	[Token(Token = "0x400AA13")]
	[FieldOffset(Offset = "0xC")]
	public float new_probability;

	[Token(Token = "0x400AA14")]
	[FieldOffset(Offset = "0x10")]
	public bool br_tutorial_open;

	[Token(Token = "0x400AA15")]
	[FieldOffset(Offset = "0x14")]
	public float br_tutorial_probability;

	[Token(Token = "0x400AA16")]
	[FieldOffset(Offset = "0x18")]
	public bool cs_tutorial_open;

	[Token(Token = "0x400AA17")]
	[FieldOffset(Offset = "0x1C")]
	public float cs_tutorial_probability;

	[Token(Token = "0x400AA18")]
	[FieldOffset(Offset = "0x20")]
	public float cs_abtest;

	[Token(Token = "0x400AA19")]
	[FieldOffset(Offset = "0x24")]
	public bool basic_guide_open;

	[Token(Token = "0x400AA1A")]
	[FieldOffset(Offset = "0x28")]
	public float basic_guide_probability;

	[Token(Token = "0x6008169")]
	[Address(RVA = "0x33DE7E4", Offset = "0x33DE7E4", VA = "0x33DE7E4")]
	public NewRegisterProcedureDesc()
	{
	}
}
