using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200366D")]
public class UIHudGuildWarIntroInfoView : UIBaseView
{
	[Token(Token = "0x4015D7B")]
	[FieldOffset(Offset = "0x14")]
	public UISprite LeftTeamClanIcon;

	[Token(Token = "0x4015D7C")]
	[FieldOffset(Offset = "0x18")]
	public UISprite RightTeamClanIcon;

	[Token(Token = "0x4015D7D")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel IntroDetail;

	[Token(Token = "0x60166F4")]
	[Address(RVA = "0x133C6A8", Offset = "0x133C6A8", VA = "0x133C6A8")]
	public UIHudGuildWarIntroInfoView()
	{
	}

	[Token(Token = "0x60166F5")]
	[Address(RVA = "0x133C6B0", Offset = "0x133C6B0", VA = "0x133C6B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166F6")]
	[Address(RVA = "0x133C918", Offset = "0x133C918", VA = "0x133C918")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
