using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039CC")]
public class UISPHudRemainingInfoView : UIBaseView
{
	[Token(Token = "0x4018513")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SoloPanel;

	[Token(Token = "0x4018514")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SGroupMode;

	[Token(Token = "0x4018515")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SSafeZoneGo;

	[Token(Token = "0x4018516")]
	[FieldOffset(Offset = "0x20")]
	public UILabel SSafeZoneCount;

	[Token(Token = "0x4018517")]
	[FieldOffset(Offset = "0x24")]
	public UILabel SAlivePlayerCount;

	[Token(Token = "0x4018518")]
	[FieldOffset(Offset = "0x28")]
	public GameObject STime;

	[Token(Token = "0x4018519")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel STimeLabel;

	[Token(Token = "0x401851A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject MultiPanel;

	[Token(Token = "0x401851B")]
	[FieldOffset(Offset = "0x34")]
	public UILabel MAlivePlayerCount;

	[Token(Token = "0x401851C")]
	[FieldOffset(Offset = "0x38")]
	public GameObject MTeamGo;

	[Token(Token = "0x401851D")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel MAliveTeamCount;

	[Token(Token = "0x401851E")]
	[FieldOffset(Offset = "0x40")]
	public GameObject MTime;

	[Token(Token = "0x401851F")]
	[FieldOffset(Offset = "0x44")]
	public UILabel MTimeLabel;

	[Token(Token = "0x4018520")]
	[FieldOffset(Offset = "0x48")]
	public UILabel MGroupMode;

	[Token(Token = "0x4018521")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject MSafeZoneGo;

	[Token(Token = "0x4018522")]
	[FieldOffset(Offset = "0x50")]
	public UILabel MSafeZoneCount;

	[Token(Token = "0x601710A")]
	[Address(RVA = "0x1D2A8A8", Offset = "0x1D2A8A8", VA = "0x1D2A8A8")]
	public UISPHudRemainingInfoView()
	{
	}

	[Token(Token = "0x601710B")]
	[Address(RVA = "0x1D2A8B0", Offset = "0x1D2A8B0", VA = "0x1D2A8B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601710C")]
	[Address(RVA = "0x1D2AE78", Offset = "0x1D2AE78", VA = "0x1D2AE78")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
