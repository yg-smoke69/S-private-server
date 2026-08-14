using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A19")]
public class UITutorialView : UIBaseView
{
	[Token(Token = "0x4018881")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4018882")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4018883")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GoDots;

	[Token(Token = "0x4018884")]
	[FieldOffset(Offset = "0x20")]
	public Transform TrDots;

	[Token(Token = "0x4018885")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GoWrap;

	[Token(Token = "0x4018886")]
	[FieldOffset(Offset = "0x28")]
	public Transform TrWrap;

	[Token(Token = "0x60171F1")]
	[Address(RVA = "0x2B7E1BC", Offset = "0x2B7E1BC", VA = "0x2B7E1BC")]
	public UITutorialView()
	{
	}

	[Token(Token = "0x60171F2")]
	[Address(RVA = "0x2B7E1C4", Offset = "0x2B7E1C4", VA = "0x2B7E1C4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171F3")]
	[Address(RVA = "0x2B7E4E4", Offset = "0x2B7E4E4", VA = "0x2B7E4E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
