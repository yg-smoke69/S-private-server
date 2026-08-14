using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036E3")]
public class UIHudPlayerMarkView : UIBaseView
{
	[Token(Token = "0x40162AC")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelTeamId;

	[Token(Token = "0x40162AD")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Icon;

	[Token(Token = "0x40162AE")]
	[FieldOffset(Offset = "0x1C")]
	public Transform Root;

	[Token(Token = "0x40162AF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject EnemyMark;

	[Token(Token = "0x6016854")]
	[Address(RVA = "0x186700C", Offset = "0x186700C", VA = "0x186700C")]
	public UIHudPlayerMarkView()
	{
	}

	[Token(Token = "0x6016855")]
	[Address(RVA = "0x1867014", Offset = "0x1867014", VA = "0x1867014", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016856")]
	[Address(RVA = "0x18672A8", Offset = "0x18672A8", VA = "0x18672A8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
