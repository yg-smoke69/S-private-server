using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200398E")]
public class UISceneEditCreatorFeedbackPopWndView : UIBaseView
{
	[Token(Token = "0x40181C9")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Remark;

	[Token(Token = "0x40181CA")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid DataGrid;

	[Token(Token = "0x40181CB")]
	[FieldOffset(Offset = "0x1C")]
	public Transform FirstNode;

	[Token(Token = "0x40181CC")]
	[FieldOffset(Offset = "0x20")]
	public Transform SecondNode;

	[Token(Token = "0x6017051")]
	[Address(RVA = "0x14ACC08", Offset = "0x14ACC08", VA = "0x14ACC08")]
	public UISceneEditCreatorFeedbackPopWndView()
	{
	}

	[Token(Token = "0x6017052")]
	[Address(RVA = "0x14ACC10", Offset = "0x14ACC10", VA = "0x14ACC10", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017053")]
	[Address(RVA = "0x14ACE88", Offset = "0x14ACE88", VA = "0x14ACE88")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
