using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200394B")]
public class UIRelationshipBreakRequsetConfirmView : UIBaseView
{
	[Token(Token = "0x4017FC1")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4017FC2")]
	[FieldOffset(Offset = "0x18")]
	public UIButton RefuseBtn;

	[Token(Token = "0x4017FC3")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ConfirmInfoText;

	[Token(Token = "0x6016F88")]
	[Address(RVA = "0x1E46E30", Offset = "0x1E46E30", VA = "0x1E46E30")]
	public UIRelationshipBreakRequsetConfirmView()
	{
	}

	[Token(Token = "0x6016F89")]
	[Address(RVA = "0x1E46E38", Offset = "0x1E46E38", VA = "0x1E46E38", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F8A")]
	[Address(RVA = "0x1E470A0", Offset = "0x1E470A0", VA = "0x1E470A0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
