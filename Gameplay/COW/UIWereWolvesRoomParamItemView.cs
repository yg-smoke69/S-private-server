using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A83")]
public class UIWereWolvesRoomParamItemView : UIBaseView
{
	[Token(Token = "0x4018DFA")]
	[FieldOffset(Offset = "0x14")]
	public UIButton PlusBtn;

	[Token(Token = "0x4018DFB")]
	[FieldOffset(Offset = "0x18")]
	public UIButton SubBtn;

	[Token(Token = "0x4018DFC")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel CountLabel;

	[Token(Token = "0x4018DFD")]
	[FieldOffset(Offset = "0x20")]
	public UIButton MinBtn;

	[Token(Token = "0x4018DFE")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelMin;

	[Token(Token = "0x4018DFF")]
	[FieldOffset(Offset = "0x28")]
	public UIButton MaxBtn;

	[Token(Token = "0x4018E00")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LabelMax;

	[Token(Token = "0x4018E01")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ParamNameLabel;

	[Token(Token = "0x601732F")]
	[Address(RVA = "0x1B8D1DC", Offset = "0x1B8D1DC", VA = "0x1B8D1DC")]
	public UIWereWolvesRoomParamItemView()
	{
	}

	[Token(Token = "0x6017330")]
	[Address(RVA = "0x1B8D1E4", Offset = "0x1B8D1E4", VA = "0x1B8D1E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017331")]
	[Address(RVA = "0x1B8D62C", Offset = "0x1B8D62C", VA = "0x1B8D62C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
