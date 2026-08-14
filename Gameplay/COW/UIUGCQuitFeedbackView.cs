using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A43")]
public class UIUGCQuitFeedbackView : UIBaseView
{
	[Token(Token = "0x40189DA")]
	[FieldOffset(Offset = "0x14")]
	public Transform optionRoot;

	[Token(Token = "0x40189DB")]
	[FieldOffset(Offset = "0x18")]
	public UIButton btn_ok;

	[Token(Token = "0x40189DC")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton btn_cancel;

	[Token(Token = "0x40189DD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject btn_grey;

	[Token(Token = "0x40189DE")]
	[FieldOffset(Offset = "0x24")]
	public UILabel quitCountDownLabel;

	[Token(Token = "0x601726F")]
	[Address(RVA = "0x2790D08", Offset = "0x2790D08", VA = "0x2790D08")]
	public UIUGCQuitFeedbackView()
	{
	}

	[Token(Token = "0x6017270")]
	[Address(RVA = "0x2790D10", Offset = "0x2790D10", VA = "0x2790D10", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017271")]
	[Address(RVA = "0x2791004", Offset = "0x2791004", VA = "0x2791004")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
