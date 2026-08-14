using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003433")]
public class UIChatSendSpeakerView : UIBaseView
{
	[Token(Token = "0x4014326")]
	[FieldOffset(Offset = "0x14")]
	public UIInput InputField;

	[Token(Token = "0x4014327")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SpeakerNum;

	[Token(Token = "0x4014328")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton SendBtn;

	[Token(Token = "0x4014329")]
	[FieldOffset(Offset = "0x20")]
	public UILabel StrLength;

	[Token(Token = "0x601604D")]
	[Address(RVA = "0x207BBEC", Offset = "0x207BBEC", VA = "0x207BBEC")]
	public UIChatSendSpeakerView()
	{
	}

	[Token(Token = "0x601604E")]
	[Address(RVA = "0x207BBF4", Offset = "0x207BBF4", VA = "0x207BBF4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601604F")]
	[Address(RVA = "0x207BEBC", Offset = "0x207BEBC", VA = "0x207BEBC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
