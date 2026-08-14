using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039BD")]
public class UISPHudCSRoundResultItemView : UIBaseView
{
	[Token(Token = "0x4018439")]
	[FieldOffset(Offset = "0x14")]
	public UILabel RoundId;

	[Token(Token = "0x401843A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject RedWinObj;

	[Token(Token = "0x401843B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RedWin;

	[Token(Token = "0x401843C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject RedExplode;

	[Token(Token = "0x401843D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RedRemove;

	[Token(Token = "0x401843E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BlueWinObj;

	[Token(Token = "0x401843F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BlueWin;

	[Token(Token = "0x4018440")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BlueExplode;

	[Token(Token = "0x4018441")]
	[FieldOffset(Offset = "0x34")]
	public GameObject BlueRemove;

	[Token(Token = "0x60170DE")]
	[Address(RVA = "0x1D1768C", Offset = "0x1D1768C", VA = "0x1D1768C")]
	public UISPHudCSRoundResultItemView()
	{
	}

	[Token(Token = "0x60170DF")]
	[Address(RVA = "0x1D17694", Offset = "0x1D17694", VA = "0x1D17694", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170E0")]
	[Address(RVA = "0x1D17A18", Offset = "0x1D17A18", VA = "0x1D17A18")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
