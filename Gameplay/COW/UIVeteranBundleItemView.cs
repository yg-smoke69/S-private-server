using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A52")]
public class UIVeteranBundleItemView : UIBaseView
{
	[Token(Token = "0x4018A95")]
	[FieldOffset(Offset = "0x14")]
	public Transform AwardItemGrid;

	[Token(Token = "0x4018A96")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Desc;

	[Token(Token = "0x601729C")]
	[Address(RVA = "0x28453E0", Offset = "0x28453E0", VA = "0x28453E0")]
	public UIVeteranBundleItemView()
	{
	}

	[Token(Token = "0x601729D")]
	[Address(RVA = "0x28453E8", Offset = "0x28453E8", VA = "0x28453E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601729E")]
	[Address(RVA = "0x28455C8", Offset = "0x28455C8", VA = "0x28455C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
