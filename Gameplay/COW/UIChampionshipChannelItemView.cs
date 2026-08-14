using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200340A")]
public class UIChampionshipChannelItemView : UIBaseView
{
	[Token(Token = "0x401413D")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Item;

	[Token(Token = "0x401413E")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Channel;

	[Token(Token = "0x6015FD2")]
	[Address(RVA = "0x145D848", Offset = "0x145D848", VA = "0x145D848")]
	public UIChampionshipChannelItemView()
	{
	}

	[Token(Token = "0x6015FD3")]
	[Address(RVA = "0x145D850", Offset = "0x145D850", VA = "0x145D850", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FD4")]
	[Address(RVA = "0x145DA58", Offset = "0x145DA58", VA = "0x145DA58")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
