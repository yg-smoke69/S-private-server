using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200366E")]
public class UIHudHardwareInputGuideView : UIBaseView
{
	[Token(Token = "0x4015D7E")]
	[FieldOffset(Offset = "0x14")]
	public UITable Table;

	[Token(Token = "0x4015D7F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Fire;

	[Token(Token = "0x4015D80")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Move;

	[Token(Token = "0x4015D81")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Foward;

	[Token(Token = "0x4015D82")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Left;

	[Token(Token = "0x4015D83")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Backward;

	[Token(Token = "0x4015D84")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Right;

	[Token(Token = "0x4015D85")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Reload;

	[Token(Token = "0x4015D86")]
	[FieldOffset(Offset = "0x34")]
	public UILabel CursorLock;

	[Token(Token = "0x4015D87")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Dash;

	[Token(Token = "0x4015D88")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel SkateDown;

	[Token(Token = "0x4015D89")]
	[FieldOffset(Offset = "0x40")]
	public UILabel VehicleHorn;

	[Token(Token = "0x60166F7")]
	[Address(RVA = "0x133F488", Offset = "0x133F488", VA = "0x133F488")]
	public UIHudHardwareInputGuideView()
	{
	}

	[Token(Token = "0x60166F8")]
	[Address(RVA = "0x133F490", Offset = "0x133F490", VA = "0x133F490", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166F9")]
	[Address(RVA = "0x133FA40", Offset = "0x133FA40", VA = "0x133FA40")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
