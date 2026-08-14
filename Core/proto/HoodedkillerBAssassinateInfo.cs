using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001838")]
public class HoodedkillerBAssassinateInfo
{
	[Token(Token = "0x4009C5F")]
	[FieldOffset(Offset = "0x8")]
	public uint target_id;

	[Token(Token = "0x4009C60")]
	[FieldOffset(Offset = "0xC")]
	public uint sword_times;

	[Token(Token = "0x4009C61")]
	[FieldOffset(Offset = "0x10")]
	public uint sleeve_arrow_times;

	[Token(Token = "0x4009C62")]
	[FieldOffset(Offset = "0x18")]
	public long success_at;

	[Token(Token = "0x4009C63")]
	[FieldOffset(Offset = "0x20")]
	public bool is_dead;

	[Token(Token = "0x6007E92")]
	[Address(RVA = "0x30A2FC4", Offset = "0x30A2FC4", VA = "0x30A2FC4")]
	public HoodedkillerBAssassinateInfo()
	{
	}
}
