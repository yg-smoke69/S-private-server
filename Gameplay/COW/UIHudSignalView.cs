using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003745")]
public class UIHudSignalView : UIBaseView
{
	[Token(Token = "0x40165A3")]
	[FieldOffset(Offset = "0x14")]
	public UISprite SignalIcon;

	[Token(Token = "0x40165A4")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SignalLabel;

	[Token(Token = "0x601697A")]
	[Address(RVA = "0x16BACEC", Offset = "0x16BACEC", VA = "0x16BACEC")]
	public UIHudSignalView()
	{
	}

	[Token(Token = "0x601697B")]
	[Address(RVA = "0x16BACF4", Offset = "0x16BACF4", VA = "0x16BACF4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601697C")]
	[Address(RVA = "0x16BAEFC", Offset = "0x16BAEFC", VA = "0x16BAEFC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
