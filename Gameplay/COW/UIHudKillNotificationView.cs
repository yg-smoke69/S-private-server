using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200368F")]
public class UIHudKillNotificationView : UIBaseView
{
	[Token(Token = "0x4015F1B")]
	[FieldOffset(Offset = "0x14")]
	public UIHudKillNotificationItem Item1;

	[Token(Token = "0x4015F1C")]
	[FieldOffset(Offset = "0x18")]
	public UIHudKillNotificationItem Item2;

	[Token(Token = "0x4015F1D")]
	[FieldOffset(Offset = "0x1C")]
	public UIHudKillNotificationItem Item3;

	[Token(Token = "0x4015F1E")]
	[FieldOffset(Offset = "0x20")]
	public UIHudKillNotificationMiniItem MiniItem1;

	[Token(Token = "0x4015F1F")]
	[FieldOffset(Offset = "0x24")]
	public UIHudKillNotificationMiniItem MiniItem2;

	[Token(Token = "0x4015F20")]
	[FieldOffset(Offset = "0x28")]
	public UIHudKillNotificationMiniItem MiniItem3;

	[Token(Token = "0x4015F21")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget UIHudKillNotification;

	[Token(Token = "0x601675A")]
	[Address(RVA = "0x1BBB198", Offset = "0x1BBB198", VA = "0x1BBB198")]
	public UIHudKillNotificationView()
	{
	}

	[Token(Token = "0x601675B")]
	[Address(RVA = "0x1BBB1A0", Offset = "0x1BBB1A0", VA = "0x1BBB1A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601675C")]
	[Address(RVA = "0x1BBB588", Offset = "0x1BBB588", VA = "0x1BBB588")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
