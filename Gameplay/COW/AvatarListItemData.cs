using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024B6")]
public class AvatarListItemData
{
	[Token(Token = "0x400E3A8")]
	[FieldOffset(Offset = "0x8")]
	public AvatarProfile profile;

	[Token(Token = "0x400E3A9")]
	[FieldOffset(Offset = "0xC")]
	public bool isCurrentSelected;

	[Token(Token = "0x400E3AA")]
	[FieldOffset(Offset = "0xD")]
	public bool isCurrentEquipped;

	[Token(Token = "0x600D28F")]
	[Address(RVA = "0x234D5A4", Offset = "0x234D5A4", VA = "0x234D5A4")]
	public AvatarListItemData()
	{
	}
}
