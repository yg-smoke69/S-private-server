using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037DC")]
public class UIHudWereWolvesTaskWolfListItemView : UIBaseView
{
	[Token(Token = "0x4016A62")]
	[FieldOffset(Offset = "0x14")]
	public UILabel DescLabel;

	[Token(Token = "0x4016A63")]
	[FieldOffset(Offset = "0x18")]
	public UISprite TaskIcon;

	[Token(Token = "0x6016B3F")]
	[Address(RVA = "0x2572B3C", Offset = "0x2572B3C", VA = "0x2572B3C")]
	public UIHudWereWolvesTaskWolfListItemView()
	{
	}

	[Token(Token = "0x6016B40")]
	[Address(RVA = "0x2572B44", Offset = "0x2572B44", VA = "0x2572B44", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B41")]
	[Address(RVA = "0x2572D4C", Offset = "0x2572D4C", VA = "0x2572D4C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
