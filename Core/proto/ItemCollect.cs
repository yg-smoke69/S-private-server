using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013DC")]
public class ItemCollect
{
	[Token(Token = "0x4008B50")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x4008B51")]
	[FieldOffset(Offset = "0xC")]
	public uint cnt;

	[Token(Token = "0x6007ABD")]
	[Address(RVA = "0x30A3FA4", Offset = "0x30A3FA4", VA = "0x30A3FA4")]
	public ItemCollect()
	{
	}
}
