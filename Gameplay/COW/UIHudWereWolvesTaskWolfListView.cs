using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037DD")]
public class UIHudWereWolvesTaskWolfListView : UIBaseView
{
	[Token(Token = "0x4016A64")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ExpandNode;

	[Token(Token = "0x4016A65")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ContentScrollView;

	[Token(Token = "0x4016A66")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList ContentList;

	[Token(Token = "0x4016A67")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnShrink;

	[Token(Token = "0x4016A68")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ShrinkNode;

	[Token(Token = "0x4016A69")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnExpand;

	[Token(Token = "0x6016B42")]
	[Address(RVA = "0x2572D54", Offset = "0x2572D54", VA = "0x2572D54")]
	public UIHudWereWolvesTaskWolfListView()
	{
	}

	[Token(Token = "0x6016B43")]
	[Address(RVA = "0x2572D5C", Offset = "0x2572D5C", VA = "0x2572D5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B44")]
	[Address(RVA = "0x25730CC", Offset = "0x25730CC", VA = "0x25730CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
