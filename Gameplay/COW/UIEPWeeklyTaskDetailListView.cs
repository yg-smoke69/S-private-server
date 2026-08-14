using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003526")]
public class UIEPWeeklyTaskDetailListView : UIBaseView
{
	[Token(Token = "0x4014FAF")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Desc;

	[Token(Token = "0x4014FB0")]
	[FieldOffset(Offset = "0x18")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x4014FB1")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ProgressCnt;

	[Token(Token = "0x4014FB2")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList EasyList;

	[Token(Token = "0x6016322")]
	[Address(RVA = "0x2A39594", Offset = "0x2A39594", VA = "0x2A39594")]
	public UIEPWeeklyTaskDetailListView()
	{
	}

	[Token(Token = "0x6016323")]
	[Address(RVA = "0x2A3959C", Offset = "0x2A3959C", VA = "0x2A3959C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016324")]
	[Address(RVA = "0x2A39864", Offset = "0x2A39864", VA = "0x2A39864")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
