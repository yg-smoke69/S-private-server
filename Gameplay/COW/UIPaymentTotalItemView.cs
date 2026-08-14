using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038FA")]
public class UIPaymentTotalItemView : UIBaseView
{
	[Token(Token = "0x4017AE0")]
	[FieldOffset(Offset = "0x14")]
	public UILabel DescLabel;

	[Token(Token = "0x4017AE1")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ClaimedLabel;

	[Token(Token = "0x4017AE2")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ClaimedSprite;

	[Token(Token = "0x4017AE3")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ClaimButton;

	[Token(Token = "0x4017AE4")]
	[FieldOffset(Offset = "0x24")]
	public UIButton TopupButton;

	[Token(Token = "0x4017AE5")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid ContentsGrid;

	[Token(Token = "0x6016E97")]
	[Address(RVA = "0x23DE958", Offset = "0x23DE958", VA = "0x23DE958")]
	public UIPaymentTotalItemView()
	{
	}

	[Token(Token = "0x6016E98")]
	[Address(RVA = "0x23DE960", Offset = "0x23DE960", VA = "0x23DE960", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E99")]
	[Address(RVA = "0x23DECDC", Offset = "0x23DECDC", VA = "0x23DECDC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
