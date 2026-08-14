using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036C7")]
public class UIHudObGlobalEventPollEntryView : UIBaseView
{
	[Token(Token = "0x40161B4")]
	[FieldOffset(Offset = "0x14")]
	public UIButton btnPoll;

	[Token(Token = "0x40161B5")]
	[FieldOffset(Offset = "0x18")]
	public UILabel btnName;

	[Token(Token = "0x40161B6")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel countDown;

	[Token(Token = "0x6016802")]
	[Address(RVA = "0x182C7E0", Offset = "0x182C7E0", VA = "0x182C7E0")]
	public UIHudObGlobalEventPollEntryView()
	{
	}

	[Token(Token = "0x6016803")]
	[Address(RVA = "0x182C7E8", Offset = "0x182C7E8", VA = "0x182C7E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016804")]
	[Address(RVA = "0x182CA50", Offset = "0x182CA50", VA = "0x182CA50")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
