using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035E8")]
public class UIHudBigHeadInfoView : UIBaseView
{
	[Token(Token = "0x4015945")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Time;

	[Token(Token = "0x4015946")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Score;

	[Token(Token = "0x4015947")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LeadingScore;

	[Token(Token = "0x4015948")]
	[FieldOffset(Offset = "0x20")]
	public UISprite LeadingBg;

	[Token(Token = "0x6016566")]
	[Address(RVA = "0x1DFEFE0", Offset = "0x1DFEFE0", VA = "0x1DFEFE0")]
	public UIHudBigHeadInfoView()
	{
	}

	[Token(Token = "0x6016567")]
	[Address(RVA = "0x1DFEFE8", Offset = "0x1DFEFE8", VA = "0x1DFEFE8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016568")]
	[Address(RVA = "0x1DFF2B0", Offset = "0x1DFF2B0", VA = "0x1DFF2B0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
