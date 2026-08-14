using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003957")]
public class UIReplayNodeView : UIBaseView
{
	[Token(Token = "0x401800E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIReplayNode;

	[Token(Token = "0x401800F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ReplayContent;

	[Token(Token = "0x4018010")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList ReplayList;

	[Token(Token = "0x4018011")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ReplayEmpty;

	[Token(Token = "0x4018012")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButtonGroup SaveToggleBtnGroup;

	[Token(Token = "0x4018013")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButton All;

	[Token(Token = "0x4018014")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton Saved;

	[Token(Token = "0x4018015")]
	[FieldOffset(Offset = "0x30")]
	public UIToggleButton Unsaved;

	[Token(Token = "0x4018016")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButtonGroup ReplayToggleBtnGroup;

	[Token(Token = "0x4018017")]
	[FieldOffset(Offset = "0x38")]
	public UIToggleButton BtnOn;

	[Token(Token = "0x4018018")]
	[FieldOffset(Offset = "0x3C")]
	public UIToggleButton BtnOff;

	[Token(Token = "0x4018019")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnTips;

	[Token(Token = "0x401801A")]
	[FieldOffset(Offset = "0x44")]
	public UILabel LblMemory;

	[Token(Token = "0x401801B")]
	[FieldOffset(Offset = "0x48")]
	public UISprite IconMemory;

	[Token(Token = "0x401801C")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite IconReplayMemory;

	[Token(Token = "0x6016FAC")]
	[Address(RVA = "0x1E56A88", Offset = "0x1E56A88", VA = "0x1E56A88")]
	public UIReplayNodeView()
	{
	}

	[Token(Token = "0x6016FAD")]
	[Address(RVA = "0x1E56A90", Offset = "0x1E56A90", VA = "0x1E56A90", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FAE")]
	[Address(RVA = "0x1E57154", Offset = "0x1E57154", VA = "0x1E57154")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
