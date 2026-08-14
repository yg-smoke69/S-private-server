using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038D8")]
public class UINotificationsSettingView : UIBaseView
{
	[Token(Token = "0x4017930")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView SettingScrollView;

	[Token(Token = "0x4017931")]
	[FieldOffset(Offset = "0x18")]
	public UITable Table;

	[Token(Token = "0x6016E31")]
	[Address(RVA = "0x26E33C0", Offset = "0x26E33C0", VA = "0x26E33C0")]
	public UINotificationsSettingView()
	{
	}

	[Token(Token = "0x6016E32")]
	[Address(RVA = "0x26E33C8", Offset = "0x26E33C8", VA = "0x26E33C8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E33")]
	[Address(RVA = "0x26E35D0", Offset = "0x26E35D0", VA = "0x26E35D0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
