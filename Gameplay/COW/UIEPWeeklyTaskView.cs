using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003527")]
public class UIEPWeeklyTaskView : UIBaseView
{
	[Token(Token = "0x4014FB3")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid Grid;

	[Token(Token = "0x4014FB4")]
	[FieldOffset(Offset = "0x18")]
	public UIEPWeeklyItemPreviewController TaskItem;

	[Token(Token = "0x4014FB5")]
	[FieldOffset(Offset = "0x1C")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x6016325")]
	[Address(RVA = "0x2A3986C", Offset = "0x2A3986C", VA = "0x2A3986C")]
	public UIEPWeeklyTaskView()
	{
	}

	[Token(Token = "0x6016326")]
	[Address(RVA = "0x2A39874", Offset = "0x2A39874", VA = "0x2A39874", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016327")]
	[Address(RVA = "0x2A39ADC", Offset = "0x2A39ADC", VA = "0x2A39ADC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
