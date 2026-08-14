using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035FC")]
public class UIHudBuffIntroView : UIBaseView
{
	[Token(Token = "0x40159C7")]
	[FieldOffset(Offset = "0x14")]
	public UISprite IconBuff;

	[Token(Token = "0x40159C8")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelLeftTime;

	[Token(Token = "0x40159C9")]
	[FieldOffset(Offset = "0x1C")]
	public UIProgressBar Progress;

	[Token(Token = "0x40159CA")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelTitle;

	[Token(Token = "0x40159CB")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelBuffName;

	[Token(Token = "0x40159CC")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelBuffDesc;

	[Token(Token = "0x60165A2")]
	[Address(RVA = "0x1E17F00", Offset = "0x1E17F00", VA = "0x1E17F00")]
	public UIHudBuffIntroView()
	{
	}

	[Token(Token = "0x60165A3")]
	[Address(RVA = "0x1E17F08", Offset = "0x1E17F08", VA = "0x1E17F08", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165A4")]
	[Address(RVA = "0x1E18290", Offset = "0x1E18290", VA = "0x1E18290")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
