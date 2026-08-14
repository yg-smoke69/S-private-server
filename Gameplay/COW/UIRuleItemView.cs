using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200397B")]
public class UIRuleItemView : UIBaseView
{
	[Token(Token = "0x401812F")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4018130")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x6017018")]
	[Address(RVA = "0x2BF6568", Offset = "0x2BF6568", VA = "0x2BF6568")]
	public UIRuleItemView()
	{
	}

	[Token(Token = "0x6017019")]
	[Address(RVA = "0x2BF6570", Offset = "0x2BF6570", VA = "0x2BF6570", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601701A")]
	[Address(RVA = "0x2BF66D8", Offset = "0x2BF66D8", VA = "0x2BF66D8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
