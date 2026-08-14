using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037DA")]
public class UIHudWereWolvesTaskListView : UIBaseView
{
	[Token(Token = "0x4016A5D")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ContentScrollView;

	[Token(Token = "0x4016A5E")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList ContentList;

	[Token(Token = "0x6016B39")]
	[Address(RVA = "0x257143C", Offset = "0x257143C", VA = "0x257143C")]
	public UIHudWereWolvesTaskListView()
	{
	}

	[Token(Token = "0x6016B3A")]
	[Address(RVA = "0x2571444", Offset = "0x2571444", VA = "0x2571444", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B3B")]
	[Address(RVA = "0x257164C", Offset = "0x257164C", VA = "0x257164C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
