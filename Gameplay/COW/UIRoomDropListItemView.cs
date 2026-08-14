using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003960")]
public class UIRoomDropListItemView : UIBaseView
{
	[Token(Token = "0x401803D")]
	[FieldOffset(Offset = "0x14")]
	public UIToggleButton ToggleButton;

	[Token(Token = "0x401803E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SelectLabel;

	[Token(Token = "0x401803F")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel UnSelectLabel;

	[Token(Token = "0x4018040")]
	[FieldOffset(Offset = "0x20")]
	public UITipsButton newGo;

	[Token(Token = "0x6016FC7")]
	[Address(RVA = "0x23BCD98", Offset = "0x23BCD98", VA = "0x23BCD98")]
	public UIRoomDropListItemView()
	{
	}

	[Token(Token = "0x6016FC8")]
	[Address(RVA = "0x23BCDA0", Offset = "0x23BCDA0", VA = "0x23BCDA0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FC9")]
	[Address(RVA = "0x23BD068", Offset = "0x23BD068", VA = "0x23BD068")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
