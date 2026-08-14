using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A7D")]
public class UIWeaponUpgradeTokenExchangeView : UIBaseView
{
	[Token(Token = "0x4018D98")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid LeftItem;

	[Token(Token = "0x4018D99")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid RightItem;

	[Token(Token = "0x4018D9A")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ConversionBtn;

	[Token(Token = "0x601731D")]
	[Address(RVA = "0x1B7C930", Offset = "0x1B7C930", VA = "0x1B7C930")]
	public UIWeaponUpgradeTokenExchangeView()
	{
	}

	[Token(Token = "0x601731E")]
	[Address(RVA = "0x1B7C938", Offset = "0x1B7C938", VA = "0x1B7C938", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601731F")]
	[Address(RVA = "0x1B7CBA0", Offset = "0x1B7CBA0", VA = "0x1B7CBA0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
