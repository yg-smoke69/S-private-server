using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200397C")]
public class UIRuleNumericSettingView : UIBaseView
{
	[Token(Token = "0x4018131")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4018132")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4018133")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton PlusBtn;

	[Token(Token = "0x4018134")]
	[FieldOffset(Offset = "0x20")]
	public UIButton SubBtn;

	[Token(Token = "0x4018135")]
	[FieldOffset(Offset = "0x24")]
	public UILabel CountLabel;

	[Token(Token = "0x4018136")]
	[FieldOffset(Offset = "0x28")]
	public UIInput Input;

	[Token(Token = "0x4018137")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton MinBtn;

	[Token(Token = "0x4018138")]
	[FieldOffset(Offset = "0x30")]
	public UILabel MinNumLabel;

	[Token(Token = "0x4018139")]
	[FieldOffset(Offset = "0x34")]
	public UIButton MaxBtn;

	[Token(Token = "0x401813A")]
	[FieldOffset(Offset = "0x38")]
	public UILabel MaxNumLabel;

	[Token(Token = "0x601701B")]
	[Address(RVA = "0x2BF74B4", Offset = "0x2BF74B4", VA = "0x2BF74B4")]
	public UIRuleNumericSettingView()
	{
	}

	[Token(Token = "0x601701C")]
	[Address(RVA = "0x2BF74BC", Offset = "0x2BF74BC", VA = "0x2BF74BC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601701D")]
	[Address(RVA = "0x2BF79C4", Offset = "0x2BF79C4", VA = "0x2BF79C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
