using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200394A")]
public class UIRelationshipBreakConfirmView : UIBaseView
{
	[Token(Token = "0x4017FBE")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4017FBF")]
	[FieldOffset(Offset = "0x18")]
	public UIButton CancelBtn;

	[Token(Token = "0x4017FC0")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ConfirmInfoText;

	[Token(Token = "0x6016F85")]
	[Address(RVA = "0x1E46290", Offset = "0x1E46290", VA = "0x1E46290")]
	public UIRelationshipBreakConfirmView()
	{
	}

	[Token(Token = "0x6016F86")]
	[Address(RVA = "0x1E46298", Offset = "0x1E46298", VA = "0x1E46298", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F87")]
	[Address(RVA = "0x1E46500", Offset = "0x1E46500", VA = "0x1E46500")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
