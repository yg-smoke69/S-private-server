using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200377E")]
public class UIHudTrainingTokenView : UIBaseView
{
	[Token(Token = "0x40167DC")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Btn;

	[Token(Token = "0x40167DD")]
	[FieldOffset(Offset = "0x18")]
	public UILabel DescLabel;

	[Token(Token = "0x40167DE")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel CntLabel;

	[Token(Token = "0x40167DF")]
	[FieldOffset(Offset = "0x20")]
	public UILabel CntAddLabel;

	[Token(Token = "0x40167E0")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TokenSprite;

	[Token(Token = "0x6016A25")]
	[Address(RVA = "0x15860E8", Offset = "0x15860E8", VA = "0x15860E8")]
	public UIHudTrainingTokenView()
	{
	}

	[Token(Token = "0x6016A26")]
	[Address(RVA = "0x15860F0", Offset = "0x15860F0", VA = "0x15860F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A27")]
	[Address(RVA = "0x1586418", Offset = "0x1586418", VA = "0x1586418")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
