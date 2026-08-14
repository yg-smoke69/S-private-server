using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033BB")]
public class UIAddictGuideView : UIBaseView
{
	[Token(Token = "0x4013C38")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture CDNBg;

	[Token(Token = "0x4013C39")]
	[FieldOffset(Offset = "0x18")]
	public UILabel title;

	[Token(Token = "0x4013C3A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject WarningHintGroup;

	[Token(Token = "0x4013C3B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel labelMessageWarning;

	[Token(Token = "0x4013C3C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel labelHint1;

	[Token(Token = "0x4013C3D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BanHintGroup;

	[Token(Token = "0x4013C3E")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel labelMessageBan;

	[Token(Token = "0x4013C3F")]
	[FieldOffset(Offset = "0x30")]
	public UILabel CountDownLabel;

	[Token(Token = "0x4013C40")]
	[FieldOffset(Offset = "0x34")]
	public UILabel labelHint2;

	[Token(Token = "0x4013C41")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ConfirmWidget;

	[Token(Token = "0x4013C42")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x6015EE7")]
	[Address(RVA = "0x1F30830", Offset = "0x1F30830", VA = "0x1F30830")]
	public UIAddictGuideView()
	{
	}

	[Token(Token = "0x6015EE8")]
	[Address(RVA = "0x1F30838", Offset = "0x1F30838", VA = "0x1F30838", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EE9")]
	[Address(RVA = "0x1F30D7C", Offset = "0x1F30D7C", VA = "0x1F30D7C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
