using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036C5")]
public class UIHudObGlobalEventActiveView : UIBaseView
{
	[Token(Token = "0x4016182")]
	[FieldOffset(Offset = "0x14")]
	public UILabel countDown;

	[Token(Token = "0x4016183")]
	[FieldOffset(Offset = "0x18")]
	public UIButton icon;

	[Token(Token = "0x60167FC")]
	[Address(RVA = "0x1F5D968", Offset = "0x1F5D968", VA = "0x1F5D968")]
	public UIHudObGlobalEventActiveView()
	{
	}

	[Token(Token = "0x60167FD")]
	[Address(RVA = "0x1F5D970", Offset = "0x1F5D970", VA = "0x1F5D970", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167FE")]
	[Address(RVA = "0x1F5DB78", Offset = "0x1F5DB78", VA = "0x1F5DB78")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
