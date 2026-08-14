using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200397E")]
public class UIRulePopMenuSettingView : UIBaseView
{
	[Token(Token = "0x4018140")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4018141")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4018142")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget PopMenuContainer;

	[Token(Token = "0x6017021")]
	[Address(RVA = "0x2BF8D78", Offset = "0x2BF8D78", VA = "0x2BF8D78")]
	public UIRulePopMenuSettingView()
	{
	}

	[Token(Token = "0x6017022")]
	[Address(RVA = "0x2BF8D80", Offset = "0x2BF8D80", VA = "0x2BF8D80", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017023")]
	[Address(RVA = "0x2BF8FE8", Offset = "0x2BF8FE8", VA = "0x2BF8FE8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
