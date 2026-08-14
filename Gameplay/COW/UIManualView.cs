using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003886")]
public class UIManualView : UIBaseView
{
	[Token(Token = "0x40174FC")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Content;

	[Token(Token = "0x40174FD")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnRightArrow;

	[Token(Token = "0x40174FE")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnLeftArrow;

	[Token(Token = "0x40174FF")]
	[FieldOffset(Offset = "0x20")]
	public Transform LeftTabContainer;

	[Token(Token = "0x4017500")]
	[FieldOffset(Offset = "0x24")]
	public UISprite BookAnimRight1;

	[Token(Token = "0x4017501")]
	[FieldOffset(Offset = "0x28")]
	public UISprite BookAnimRight2;

	[Token(Token = "0x4017502")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite BookAnimMiddle;

	[Token(Token = "0x4017503")]
	[FieldOffset(Offset = "0x30")]
	public UISprite BookAnimLeft;

	[Token(Token = "0x4017504")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnShare;

	[Token(Token = "0x4017505")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnHelp;

	[Token(Token = "0x6016D3D")]
	[Address(RVA = "0x2C4160C", Offset = "0x2C4160C", VA = "0x2C4160C")]
	public UIManualView()
	{
	}

	[Token(Token = "0x6016D3E")]
	[Address(RVA = "0x2C41614", Offset = "0x2C41614", VA = "0x2C41614", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D3F")]
	[Address(RVA = "0x2C41AE8", Offset = "0x2C41AE8", VA = "0x2C41AE8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
