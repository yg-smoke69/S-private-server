using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039E7")]
internal class UISPReplayListView : UIBaseView
{
	[Token(Token = "0x4018603")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Content;

	[Token(Token = "0x4018604")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ListScrollView;

	[Token(Token = "0x4018605")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList ListGrid;

	[Token(Token = "0x4018606")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Result;

	[Token(Token = "0x4018607")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SearchBarContainer;

	[Token(Token = "0x4018608")]
	[FieldOffset(Offset = "0x28")]
	public UIInput SearchInput;

	[Token(Token = "0x4018609")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton SearchBtn;

	[Token(Token = "0x401860A")]
	[FieldOffset(Offset = "0x30")]
	public UISprite SearchBtnSprite;

	[Token(Token = "0x401860B")]
	[FieldOffset(Offset = "0x34")]
	public UIButton ClearBtn;

	[Token(Token = "0x601715B")]
	[Address(RVA = "0x14AB340", Offset = "0x14AB340", VA = "0x14AB340")]
	public UISPReplayListView()
	{
	}

	[Token(Token = "0x601715C")]
	[Address(RVA = "0x14AB348", Offset = "0x14AB348", VA = "0x14AB348", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601715D")]
	[Address(RVA = "0x14AB6CC", Offset = "0x14AB6CC", VA = "0x14AB6CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
