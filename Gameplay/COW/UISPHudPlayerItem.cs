using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D3F")]
internal class UISPHudPlayerItem : MonoBehaviour
{
	[Token(Token = "0x40114CC")]
	[FieldOffset(Offset = "0xC")]
	public UIWidget Widget;

	[Token(Token = "0x40114CD")]
	[FieldOffset(Offset = "0x10")]
	public UILabel No;

	[Token(Token = "0x40114CE")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Name;

	[Token(Token = "0x40114CF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Cnt;

	[Token(Token = "0x40114D0")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton Btn;

	[Token(Token = "0x40114D1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject DeadMask;

	[Token(Token = "0x40114D2")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SelectedBG;

	[Token(Token = "0x40114D3")]
	[FieldOffset(Offset = "0x28")]
	private PlayerData m_PlayerData;

	[Token(Token = "0x6012EDF")]
	[Address(RVA = "0x1D279C4", Offset = "0x1D279C4", VA = "0x1D279C4")]
	public UISPHudPlayerItem()
	{
	}

	[Token(Token = "0x6012EE0")]
	[Address(RVA = "0x1D279CC", Offset = "0x1D279CC", VA = "0x1D279CC")]
	public void Init()
	{
	}

	[Token(Token = "0x6012EE1")]
	[Address(RVA = "0x1D27BD8", Offset = "0x1D27BD8", VA = "0x1D27BD8")]
	public void SelectedPlayer(Player targetPlayer)
	{
	}

	[Token(Token = "0x6012EE2")]
	[Address(RVA = "0x1D27DD0", Offset = "0x1D27DD0", VA = "0x1D27DD0")]
	public void SetUIData(PlayerData data, int height, int index)
	{
	}

	[Token(Token = "0x6012EE3")]
	[Address(RVA = "0x1D285A4", Offset = "0x1D285A4", VA = "0x1D285A4")]
	private void OnPlayerClick()
	{
	}

	[Token(Token = "0x6012EE4")]
	[Address(RVA = "0x1D2807C", Offset = "0x1D2807C", VA = "0x1D2807C")]
	public void SetPlayerStates(bool isDead)
	{
	}
}
