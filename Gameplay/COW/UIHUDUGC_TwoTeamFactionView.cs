using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037AF")]
public class UIHUDUGC_TwoTeamFactionView : UIBaseView
{
	[Token(Token = "0x40168CF")]
	[FieldOffset(Offset = "0x14")]
	public UILabel myTeamName;

	[Token(Token = "0x40168D0")]
	[FieldOffset(Offset = "0x18")]
	public UILabel myTeamDesc;

	[Token(Token = "0x40168D1")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite myTeamIcon;

	[Token(Token = "0x40168D2")]
	[FieldOffset(Offset = "0x20")]
	public UISprite myDefaultTeamIcon;

	[Token(Token = "0x40168D3")]
	[FieldOffset(Offset = "0x24")]
	public UILabel oppoTeamName;

	[Token(Token = "0x40168D4")]
	[FieldOffset(Offset = "0x28")]
	public UILabel oppoTeamDesc;

	[Token(Token = "0x40168D5")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite oppoTeamIcon;

	[Token(Token = "0x40168D6")]
	[FieldOffset(Offset = "0x30")]
	public UISprite oppoDefaultTeamIcon;

	[Token(Token = "0x6016AB8")]
	[Address(RVA = "0x29269D4", Offset = "0x29269D4", VA = "0x29269D4")]
	public UIHUDUGC_TwoTeamFactionView()
	{
	}

	[Token(Token = "0x6016AB9")]
	[Address(RVA = "0x29269DC", Offset = "0x29269DC", VA = "0x29269DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016ABA")]
	[Address(RVA = "0x2926E24", Offset = "0x2926E24", VA = "0x2926E24")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
