using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036FC")]
public class UIHUDReadyVoteView : UIBaseView
{
	[Token(Token = "0x4016362")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ShowRoot;

	[Token(Token = "0x4016363")]
	[FieldOffset(Offset = "0x18")]
	public UIButton VoteBtn;

	[Token(Token = "0x4016364")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite icon;

	[Token(Token = "0x4016365")]
	[FieldOffset(Offset = "0x20")]
	public UISprite bg;

	[Token(Token = "0x601689F")]
	[Address(RVA = "0x1687A70", Offset = "0x1687A70", VA = "0x1687A70")]
	public UIHUDReadyVoteView()
	{
	}

	[Token(Token = "0x60168A0")]
	[Address(RVA = "0x1687A78", Offset = "0x1687A78", VA = "0x1687A78", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168A1")]
	[Address(RVA = "0x1687D34", Offset = "0x1687D34", VA = "0x1687D34")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
