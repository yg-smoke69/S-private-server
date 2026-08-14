using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A42")]
public class UIUGCQuitFeedbackItemView : UIBaseView
{
	[Token(Token = "0x40189D7")]
	[FieldOffset(Offset = "0x14")]
	public UILabel des;

	[Token(Token = "0x40189D8")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Selected;

	[Token(Token = "0x40189D9")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton UIUGCQuitFeedbackItem;

	[Token(Token = "0x601726C")]
	[Address(RVA = "0x2790A9C", Offset = "0x2790A9C", VA = "0x2790A9C")]
	public UIUGCQuitFeedbackItemView()
	{
	}

	[Token(Token = "0x601726D")]
	[Address(RVA = "0x2790AA4", Offset = "0x2790AA4", VA = "0x2790AA4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601726E")]
	[Address(RVA = "0x2790D00", Offset = "0x2790D00", VA = "0x2790D00")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
