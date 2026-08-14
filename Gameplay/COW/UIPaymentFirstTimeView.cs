using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038E8")]
public class UIPaymentFirstTimeView : UIBaseView
{
	[Token(Token = "0x4017A10")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIPaymentFirstTime;

	[Token(Token = "0x4017A11")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTextureExt MainAdNetworkTexture;

	[Token(Token = "0x4017A12")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton NetWorkImgBtn;

	[Token(Token = "0x4017A13")]
	[FieldOffset(Offset = "0x20")]
	public UIButton GotoButton;

	[Token(Token = "0x4017A14")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ButtonLabel;

	[Token(Token = "0x4017A15")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BtnOperateBgWhite;

	[Token(Token = "0x4017A16")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BtnOperateBgGray;

	[Token(Token = "0x4017A17")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BtnOperateBgYellow;

	[Token(Token = "0x4017A18")]
	[FieldOffset(Offset = "0x34")]
	public UIButton HelpButton;

	[Token(Token = "0x6016E61")]
	[Address(RVA = "0x2888AE0", Offset = "0x2888AE0", VA = "0x2888AE0")]
	public UIPaymentFirstTimeView()
	{
	}

	[Token(Token = "0x6016E62")]
	[Address(RVA = "0x2888AE8", Offset = "0x2888AE8", VA = "0x2888AE8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E63")]
	[Address(RVA = "0x2888F60", Offset = "0x2888F60", VA = "0x2888F60")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
