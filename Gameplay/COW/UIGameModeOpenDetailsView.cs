using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035AA")]
public class UIGameModeOpenDetailsView : UIBaseView
{
	[Token(Token = "0x40156D8")]
	[FieldOffset(Offset = "0x14")]
	public GameObject openTime;

	[Token(Token = "0x40156D9")]
	[FieldOffset(Offset = "0x18")]
	public UILabel openPeriod;

	[Token(Token = "0x40156DA")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject tag;

	[Token(Token = "0x40156DB")]
	[FieldOffset(Offset = "0x20")]
	public UISprite tagSprite;

	[Token(Token = "0x40156DC")]
	[FieldOffset(Offset = "0x24")]
	public UILabel tagLabel;

	[Token(Token = "0x40156DD")]
	[FieldOffset(Offset = "0x28")]
	public UISprite tagSpritebg;

	[Token(Token = "0x60164AC")]
	[Address(RVA = "0x218C2B8", Offset = "0x218C2B8", VA = "0x218C2B8")]
	public UIGameModeOpenDetailsView()
	{
	}

	[Token(Token = "0x60164AD")]
	[Address(RVA = "0x218C2C0", Offset = "0x218C2C0", VA = "0x218C2C0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164AE")]
	[Address(RVA = "0x218C630", Offset = "0x218C630", VA = "0x218C630")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
