using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003706")]
public class UIHudReloadBtnView : UIBaseView
{
	[Token(Token = "0x4016384")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnReload;

	[Token(Token = "0x4016385")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Red;

	[Token(Token = "0x4016386")]
	[FieldOffset(Offset = "0x1C")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x4016387")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Progress;

	[Token(Token = "0x60168BD")]
	[Address(RVA = "0x13E04EC", Offset = "0x13E04EC", VA = "0x13E04EC")]
	public UIHudReloadBtnView()
	{
	}

	[Token(Token = "0x60168BE")]
	[Address(RVA = "0x13E04F4", Offset = "0x13E04F4", VA = "0x13E04F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168BF")]
	[Address(RVA = "0x13E07B0", Offset = "0x13E07B0", VA = "0x13E07B0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
