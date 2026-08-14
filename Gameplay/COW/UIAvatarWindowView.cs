using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033DF")]
public class UIAvatarWindowView : UIBaseView
{
	[Token(Token = "0x4013EDA")]
	[FieldOffset(Offset = "0x14")]
	public Transform UIAvatarWindow;

	[Token(Token = "0x4013EDB")]
	[FieldOffset(Offset = "0x18")]
	public Transform namePanels;

	[Token(Token = "0x6015F53")]
	[Address(RVA = "0x13FD594", Offset = "0x13FD594", VA = "0x13FD594")]
	public UIAvatarWindowView()
	{
	}

	[Token(Token = "0x6015F54")]
	[Address(RVA = "0x13FD59C", Offset = "0x13FD59C", VA = "0x13FD59C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F55")]
	[Address(RVA = "0x13FD754", Offset = "0x13FD754", VA = "0x13FD754")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
