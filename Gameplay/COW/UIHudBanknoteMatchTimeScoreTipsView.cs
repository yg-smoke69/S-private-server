using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035E0")]
public class UIHudBanknoteMatchTimeScoreTipsView : UIBaseView
{
	[Token(Token = "0x4015905")]
	[FieldOffset(Offset = "0x14")]
	public Animation Anim;

	[Token(Token = "0x4015906")]
	[FieldOffset(Offset = "0x18")]
	public UISprite LeftTeamClanIcon;

	[Token(Token = "0x4015907")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite RightTeamClanIcon;

	[Token(Token = "0x4015908")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LocalTeamScore;

	[Token(Token = "0x4015909")]
	[FieldOffset(Offset = "0x24")]
	public UILabel OppTeamScore;

	[Token(Token = "0x401590A")]
	[FieldOffset(Offset = "0x28")]
	public UILabel PreviousPoint;

	[Token(Token = "0x401590B")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel NextPoint;

	[Token(Token = "0x601654E")]
	[Address(RVA = "0x171C014", Offset = "0x171C014", VA = "0x171C014")]
	public UIHudBanknoteMatchTimeScoreTipsView()
	{
	}

	[Token(Token = "0x601654F")]
	[Address(RVA = "0x171C01C", Offset = "0x171C01C", VA = "0x171C01C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016550")]
	[Address(RVA = "0x171C404", Offset = "0x171C404", VA = "0x171C404")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
