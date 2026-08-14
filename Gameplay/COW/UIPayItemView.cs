using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038DE")]
public class UIPayItemView : UIBaseView
{
	[Token(Token = "0x4017984")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ClickBtn;

	[Token(Token = "0x4017985")]
	[FieldOffset(Offset = "0x18")]
	public UILabel BaseDiamondCount;

	[Token(Token = "0x4017986")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject FirstTopUp;

	[Token(Token = "0x4017987")]
	[FieldOffset(Offset = "0x20")]
	public UILabel FirstTopUpDiamondCount;

	[Token(Token = "0x4017988")]
	[FieldOffset(Offset = "0x24")]
	public Animation Bonus;

	[Token(Token = "0x4017989")]
	[FieldOffset(Offset = "0x28")]
	public UILabel BonusNum;

	[Token(Token = "0x401798A")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TagBonusNum;

	[Token(Token = "0x401798B")]
	[FieldOffset(Offset = "0x30")]
	public UINetworkTextureExt IOSNetworkImage;

	[Token(Token = "0x401798C")]
	[FieldOffset(Offset = "0x34")]
	public UILabel CostAmountLabel;

	[Token(Token = "0x6016E43")]
	[Address(RVA = "0x15B6FD0", Offset = "0x15B6FD0", VA = "0x15B6FD0")]
	public UIPayItemView()
	{
	}

	[Token(Token = "0x6016E44")]
	[Address(RVA = "0x15B6FD8", Offset = "0x15B6FD8", VA = "0x15B6FD8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E45")]
	[Address(RVA = "0x15B7474", Offset = "0x15B7474", VA = "0x15B7474")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
