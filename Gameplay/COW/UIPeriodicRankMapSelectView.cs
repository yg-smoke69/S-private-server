using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003900")]
public class UIPeriodicRankMapSelectView : UIBaseView
{
	[Token(Token = "0x4017B23")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel UIPeriodicRankMapSelect;

	[Token(Token = "0x4017B24")]
	[FieldOffset(Offset = "0x18")]
	public UIToggleButton ModeBtn;

	[Token(Token = "0x4017B25")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList MapList;

	[Token(Token = "0x4017B26")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Bottom;

	[Token(Token = "0x4017B27")]
	[FieldOffset(Offset = "0x24")]
	public UILabel MapInfos;

	[Token(Token = "0x4017B28")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ExtraPoint;

	[Token(Token = "0x4017B29")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel RPLabel;

	[Token(Token = "0x4017B2A")]
	[FieldOffset(Offset = "0x30")]
	public UIButton ConfirmButton;

	[Token(Token = "0x6016EA9")]
	[Address(RVA = "0x23E4F54", Offset = "0x23E4F54", VA = "0x23E4F54")]
	public UIPeriodicRankMapSelectView()
	{
	}

	[Token(Token = "0x6016EAA")]
	[Address(RVA = "0x23E4F5C", Offset = "0x23E4F5C", VA = "0x23E4F5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EAB")]
	[Address(RVA = "0x23E538C", Offset = "0x23E538C", VA = "0x23E538C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
