using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003397")]
public class TipsWithItemsView : UIBaseView
{
	[Token(Token = "0x4013AEF")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BGPivot;

	[Token(Token = "0x4013AF0")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BG;

	[Token(Token = "0x4013AF1")]
	[FieldOffset(Offset = "0x1C")]
	public UITable Table;

	[Token(Token = "0x4013AF2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject TablePivot;

	[Token(Token = "0x4013AF3")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Mask;

	[Token(Token = "0x6015E7B")]
	[Address(RVA = "0x28AD26C", Offset = "0x28AD26C", VA = "0x28AD26C")]
	public TipsWithItemsView()
	{
	}

	[Token(Token = "0x6015E7C")]
	[Address(RVA = "0x28AD274", Offset = "0x28AD274", VA = "0x28AD274", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E7D")]
	[Address(RVA = "0x28AD578", Offset = "0x28AD578", VA = "0x28AD578")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
