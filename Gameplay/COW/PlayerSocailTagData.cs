using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AA4")]
public class PlayerSocailTagData : PlayerTagDataBase
{
	[Token(Token = "0x401060E")]
	[FieldOffset(Offset = "0xC")]
	public string Title;

	[Token(Token = "0x401060F")]
	[FieldOffset(Offset = "0x10")]
	public string Desc;

	[Token(Token = "0x4010610")]
	[FieldOffset(Offset = "0x14")]
	public bool IsShow;

	[Token(Token = "0x4010611")]
	[FieldOffset(Offset = "0x18")]
	public float equipTimeStamp;

	[Token(Token = "0x60116C2")]
	[Address(RVA = "0x1C0B738", Offset = "0x1C0B738", VA = "0x1C0B738")]
	public PlayerSocailTagData()
	{
	}
}
