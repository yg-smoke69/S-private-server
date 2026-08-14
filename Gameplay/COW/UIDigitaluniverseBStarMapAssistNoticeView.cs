using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034E1")]
public class UIDigitaluniverseBStarMapAssistNoticeView : UIBaseView
{
	[Token(Token = "0x4014C6B")]
	[FieldOffset(Offset = "0x14")]
	public UISprite ProfileIcon;

	[Token(Token = "0x4014C6C")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelPlayerName;

	[Token(Token = "0x4014C6D")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelTokenNum;

	[Token(Token = "0x4014C6E")]
	[FieldOffset(Offset = "0x20")]
	public Animation Anim;

	[Token(Token = "0x6016255")]
	[Address(RVA = "0x2F100C0", Offset = "0x2F100C0", VA = "0x2F100C0")]
	public UIDigitaluniverseBStarMapAssistNoticeView()
	{
	}

	[Token(Token = "0x6016256")]
	[Address(RVA = "0x2F100C8", Offset = "0x2F100C8", VA = "0x2F100C8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016257")]
	[Address(RVA = "0x2F10390", Offset = "0x2F10390", VA = "0x2F10390")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
