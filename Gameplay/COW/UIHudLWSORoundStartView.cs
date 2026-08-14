using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036A5")]
public class UIHudLWSORoundStartView : UIBaseView
{
	[Token(Token = "0x4016000")]
	[FieldOffset(Offset = "0x14")]
	public GameObject RoundStartContainer;

	[Token(Token = "0x4016001")]
	[FieldOffset(Offset = "0x18")]
	public UILabel RoundNum;

	[Token(Token = "0x4016002")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel GamezoneName;

	[Token(Token = "0x4016003")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HPKnife;

	[Token(Token = "0x4016004")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid MyFactionHPGrid;

	[Token(Token = "0x4016005")]
	[FieldOffset(Offset = "0x28")]
	public UILabel MyName;

	[Token(Token = "0x4016006")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite MyFactionIcon;

	[Token(Token = "0x4016007")]
	[FieldOffset(Offset = "0x30")]
	public UILabel MyTeamRank;

	[Token(Token = "0x4016008")]
	[FieldOffset(Offset = "0x34")]
	public UIGrid OppoFactionHPGrid;

	[Token(Token = "0x4016009")]
	[FieldOffset(Offset = "0x38")]
	public UILabel OppoName;

	[Token(Token = "0x401600A")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite OppoFactionIcon;

	[Token(Token = "0x401600B")]
	[FieldOffset(Offset = "0x40")]
	public UILabel OppoTeamRank;

	[Token(Token = "0x401600C")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Final;

	[Token(Token = "0x601679C")]
	[Address(RVA = "0x1BCF6D4", Offset = "0x1BCF6D4", VA = "0x1BCF6D4")]
	public UIHudLWSORoundStartView()
	{
	}

	[Token(Token = "0x601679D")]
	[Address(RVA = "0x1BCF6DC", Offset = "0x1BCF6DC", VA = "0x1BCF6DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601679E")]
	[Address(RVA = "0x1BCFCEC", Offset = "0x1BCFCEC", VA = "0x1BCFCEC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
