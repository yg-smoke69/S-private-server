using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003926")]
public class UIProfileEPSMallItemView : UIBaseView
{
	[Token(Token = "0x4017CBA")]
	[FieldOffset(Offset = "0x14")]
	public UISprite smallspr;

	[Token(Token = "0x4017CBB")]
	[FieldOffset(Offset = "0x18")]
	public UILabel EPNum;

	[Token(Token = "0x4017CBC")]
	[FieldOffset(Offset = "0x1C")]
	public UICustomHoverButton EPTipsButton;

	[Token(Token = "0x6016F19")]
	[Address(RVA = "0x16D6190", Offset = "0x16D6190", VA = "0x16D6190")]
	public UIProfileEPSMallItemView()
	{
	}

	[Token(Token = "0x6016F1A")]
	[Address(RVA = "0x16D6198", Offset = "0x16D6198", VA = "0x16D6198", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F1B")]
	[Address(RVA = "0x16D6400", Offset = "0x16D6400", VA = "0x16D6400")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
