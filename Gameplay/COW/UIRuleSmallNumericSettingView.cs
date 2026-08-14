using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003983")]
public class UIRuleSmallNumericSettingView : UIBaseView
{
	[Token(Token = "0x4018168")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4018169")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x401816A")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton PlusBtn;

	[Token(Token = "0x401816B")]
	[FieldOffset(Offset = "0x20")]
	public UIButton SubBtn;

	[Token(Token = "0x401816C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel CountLabel;

	[Token(Token = "0x401816D")]
	[FieldOffset(Offset = "0x28")]
	public UIInput Input;

	[Token(Token = "0x401816E")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton MinBtn;

	[Token(Token = "0x401816F")]
	[FieldOffset(Offset = "0x30")]
	public UILabel MinNumLabel;

	[Token(Token = "0x4018170")]
	[FieldOffset(Offset = "0x34")]
	public UIButton MaxBtn;

	[Token(Token = "0x4018171")]
	[FieldOffset(Offset = "0x38")]
	public UILabel MaxNumLabel;

	[Token(Token = "0x6017030")]
	[Address(RVA = "0x141F824", Offset = "0x141F824", VA = "0x141F824")]
	public UIRuleSmallNumericSettingView()
	{
	}

	[Token(Token = "0x6017031")]
	[Address(RVA = "0x141F82C", Offset = "0x141F82C", VA = "0x141F82C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017032")]
	[Address(RVA = "0x141FD34", Offset = "0x141FD34", VA = "0x141FD34")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
