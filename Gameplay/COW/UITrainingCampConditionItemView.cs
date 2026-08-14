using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A04")]
public class UITrainingCampConditionItemView : UIBaseView
{
	[Token(Token = "0x401879D")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ConditionLabel;

	[Token(Token = "0x401879E")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Finished;

	[Token(Token = "0x401879F")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Unfinished;

	[Token(Token = "0x60171B2")]
	[Address(RVA = "0x2AFC5A8", Offset = "0x2AFC5A8", VA = "0x2AFC5A8")]
	public UITrainingCampConditionItemView()
	{
	}

	[Token(Token = "0x60171B3")]
	[Address(RVA = "0x2AFC5B0", Offset = "0x2AFC5B0", VA = "0x2AFC5B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171B4")]
	[Address(RVA = "0x2AFC818", Offset = "0x2AFC818", VA = "0x2AFC818")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
