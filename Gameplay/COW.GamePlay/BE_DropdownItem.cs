using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000C15")]
public class BE_DropdownItem : MonoBehaviour
{
	[Token(Token = "0x400645D")]
	[FieldOffset(Offset = "0xC")]
	public BEEnumData mEnumData;

	[Token(Token = "0x400645E")]
	[FieldOffset(Offset = "0x10")]
	public UIButton mBtn;

	[Token(Token = "0x400645F")]
	[FieldOffset(Offset = "0x14")]
	public UISprite mHL;

	[Token(Token = "0x4006460")]
	[FieldOffset(Offset = "0x18")]
	public UILabel mNameLabel;

	[Token(Token = "0x6005C6A")]
	[Address(RVA = "0x2D4506C", Offset = "0x2D4506C", VA = "0x2D4506C")]
	public BE_DropdownItem()
	{
	}

	[Token(Token = "0x6005C6B")]
	[Address(RVA = "0x2D45074", Offset = "0x2D45074", VA = "0x2D45074")]
	public void Init(BEEnumData LJEJKLDPKIJ)
	{
	}
}
