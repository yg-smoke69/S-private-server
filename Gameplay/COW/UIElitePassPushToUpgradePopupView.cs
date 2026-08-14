using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200350A")]
public class UIElitePassPushToUpgradePopupView : UIBaseView
{
	[Token(Token = "0x4014E90")]
	[FieldOffset(Offset = "0x14")]
	public UIButton OKBtn;

	[Token(Token = "0x4014E91")]
	[FieldOffset(Offset = "0x18")]
	public UIButton UpgradeBtn;

	[Token(Token = "0x4014E92")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList AwardList;

	[Token(Token = "0x60162CE")]
	[Address(RVA = "0x306019C", Offset = "0x306019C", VA = "0x306019C")]
	public UIElitePassPushToUpgradePopupView()
	{
	}

	[Token(Token = "0x60162CF")]
	[Address(RVA = "0x30601A4", Offset = "0x30601A4", VA = "0x30601A4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162D0")]
	[Address(RVA = "0x306040C", Offset = "0x306040C", VA = "0x306040C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
