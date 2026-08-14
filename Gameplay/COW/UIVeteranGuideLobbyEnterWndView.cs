using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A59")]
public class UIVeteranGuideLobbyEnterWndView : UIBaseView
{
	[Token(Token = "0x4018B16")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIVeteranGuideLobbyEnterWnd;

	[Token(Token = "0x4018B17")]
	[FieldOffset(Offset = "0x18")]
	public Animation main;

	[Token(Token = "0x4018B18")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture VeteranBG;

	[Token(Token = "0x4018B19")]
	[FieldOffset(Offset = "0x20")]
	public UIButton CloseBtn;

	[Token(Token = "0x4018B1A")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Label1;

	[Token(Token = "0x4018B1B")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Label2;

	[Token(Token = "0x4018B1C")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton GotoBtn;

	[Token(Token = "0x4018B1D")]
	[FieldOffset(Offset = "0x30")]
	public UILabel BtnLabel;

	[Token(Token = "0x60172B1")]
	[Address(RVA = "0x2851358", Offset = "0x2851358", VA = "0x2851358")]
	public UIVeteranGuideLobbyEnterWndView()
	{
	}

	[Token(Token = "0x60172B2")]
	[Address(RVA = "0x2851360", Offset = "0x2851360", VA = "0x2851360", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172B3")]
	[Address(RVA = "0x285179C", Offset = "0x285179C", VA = "0x285179C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
