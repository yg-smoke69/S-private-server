using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039D8")]
internal class UISPHudSinglePlayerItemView : UIBaseView
{
	[Token(Token = "0x401855B")]
	[FieldOffset(Offset = "0x14")]
	public UISPHudPlayerItem PlayerItem;

	[Token(Token = "0x401855C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject KingOfKill;

	[Token(Token = "0x401855D")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite KingOfKillIcon;

	[Token(Token = "0x601712E")]
	[Address(RVA = "0x148EE5C", Offset = "0x148EE5C", VA = "0x148EE5C")]
	public UISPHudSinglePlayerItemView()
	{
	}

	[Token(Token = "0x601712F")]
	[Address(RVA = "0x148EE64", Offset = "0x148EE64", VA = "0x148EE64", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017130")]
	[Address(RVA = "0x148F0C0", Offset = "0x148F0C0", VA = "0x148F0C0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
