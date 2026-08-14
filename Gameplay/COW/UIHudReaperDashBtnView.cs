using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036FD")]
public class UIHudReaperDashBtnView : UIBaseView
{
	[Token(Token = "0x4016366")]
	[FieldOffset(Offset = "0x14")]
	public UIButton btnSpeedup;

	[Token(Token = "0x4016367")]
	[FieldOffset(Offset = "0x18")]
	public UISprite icon;

	[Token(Token = "0x4016368")]
	[FieldOffset(Offset = "0x1C")]
	public TweenFill CDBar;

	[Token(Token = "0x4016369")]
	[FieldOffset(Offset = "0x20")]
	public UISprite normal;

	[Token(Token = "0x401636A")]
	[FieldOffset(Offset = "0x24")]
	public UILabel CDLabel;

	[Token(Token = "0x60168A2")]
	[Address(RVA = "0x1FD8DB4", Offset = "0x1FD8DB4", VA = "0x1FD8DB4")]
	public UIHudReaperDashBtnView()
	{
	}

	[Token(Token = "0x60168A3")]
	[Address(RVA = "0x1FD8DBC", Offset = "0x1FD8DBC", VA = "0x1FD8DBC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168A4")]
	[Address(RVA = "0x1FD90E4", Offset = "0x1FD90E4", VA = "0x1FD90E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
