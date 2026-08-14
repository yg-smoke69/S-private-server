using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036F1")]
public class UIHudPVEReviveInfoView : UIBaseView
{
	[Token(Token = "0x4016327")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel Panel;

	[Token(Token = "0x4016328")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4016329")]
	[FieldOffset(Offset = "0x1C")]
	public UICountDownLabel CountDown;

	[Token(Token = "0x601687E")]
	[Address(RVA = "0x183C988", Offset = "0x183C988", VA = "0x183C988")]
	public UIHudPVEReviveInfoView()
	{
	}

	[Token(Token = "0x601687F")]
	[Address(RVA = "0x183C990", Offset = "0x183C990", VA = "0x183C990", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016880")]
	[Address(RVA = "0x183CBF8", Offset = "0x183CBF8", VA = "0x183CBF8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
