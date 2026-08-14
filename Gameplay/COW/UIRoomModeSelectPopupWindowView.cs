using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003968")]
public class UIRoomModeSelectPopupWindowView : UIBaseView
{
	[Token(Token = "0x4018090")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ApplyBtn;

	[Token(Token = "0x4018091")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ApplyLabel;

	[Token(Token = "0x4018092")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton PasswordBtn;

	[Token(Token = "0x4018093")]
	[FieldOffset(Offset = "0x20")]
	public UILabel PasswordLabel;

	[Token(Token = "0x4018094")]
	[FieldOffset(Offset = "0x24")]
	public UIButton SimulatorBtn;

	[Token(Token = "0x4018095")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SimulatorLabel;

	[Token(Token = "0x4018096")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid GroupModeGrid;

	[Token(Token = "0x4018097")]
	[FieldOffset(Offset = "0x30")]
	public UIEasyList ItemList;

	[Token(Token = "0x6016FDF")]
	[Address(RVA = "0x23D54E8", Offset = "0x23D54E8", VA = "0x23D54E8")]
	public UIRoomModeSelectPopupWindowView()
	{
	}

	[Token(Token = "0x6016FE0")]
	[Address(RVA = "0x23D54F0", Offset = "0x23D54F0", VA = "0x23D54F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FE1")]
	[Address(RVA = "0x23D5938", Offset = "0x23D5938", VA = "0x23D5938")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
