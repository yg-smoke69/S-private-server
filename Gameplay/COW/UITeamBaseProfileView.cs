using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039F9")]
public class UITeamBaseProfileView : UIBaseView
{
	[Token(Token = "0x40186EA")]
	[FieldOffset(Offset = "0x14")]
	public UIEffectSprite Callsign;

	[Token(Token = "0x40186EB")]
	[FieldOffset(Offset = "0x18")]
	public UIEffectSprite HeadPic;

	[Token(Token = "0x40186EC")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Name;

	[Token(Token = "0x40186ED")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Flag;

	[Token(Token = "0x6017191")]
	[Address(RVA = "0x20196F8", Offset = "0x20196F8", VA = "0x20196F8")]
	public UITeamBaseProfileView()
	{
	}

	[Token(Token = "0x6017192")]
	[Address(RVA = "0x2019700", Offset = "0x2019700", VA = "0x2019700", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017193")]
	[Address(RVA = "0x20199C8", Offset = "0x20199C8", VA = "0x20199C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
