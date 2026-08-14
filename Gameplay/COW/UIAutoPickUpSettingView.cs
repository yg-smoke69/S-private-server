using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033C0")]
public class UIAutoPickUpSettingView : UIBaseView
{
	[Token(Token = "0x4013C63")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4013C64")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid Grid;

	[Token(Token = "0x4013C65")]
	[FieldOffset(Offset = "0x1C")]
	public UISettingToggleGroup AutoPickupItem;

	[Token(Token = "0x6015EF6")]
	[Address(RVA = "0x1E73D24", Offset = "0x1E73D24", VA = "0x1E73D24")]
	public UIAutoPickUpSettingView()
	{
	}

	[Token(Token = "0x6015EF7")]
	[Address(RVA = "0x1E73D2C", Offset = "0x1E73D2C", VA = "0x1E73D2C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EF8")]
	[Address(RVA = "0x1E73F94", Offset = "0x1E73F94", VA = "0x1E73F94")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
