using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200389E")]
public class UIMatchResultZombieScreenshotView : UIBaseView
{
	[Token(Token = "0x4017672")]
	[FieldOffset(Offset = "0x14")]
	public ShareCamera ShareCameraObject;

	[Token(Token = "0x4017673")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ShareUI;

	[Token(Token = "0x4017674")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture HeadshotRemote;

	[Token(Token = "0x4017675")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HeadshotDefault;

	[Token(Token = "0x4017676")]
	[FieldOffset(Offset = "0x24")]
	public UIEffectSprite HeadshotLocal;

	[Token(Token = "0x4017677")]
	[FieldOffset(Offset = "0x28")]
	public UILabel PlayerID;

	[Token(Token = "0x4017678")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel PlayerNickname;

	[Token(Token = "0x4017679")]
	[FieldOffset(Offset = "0x30")]
	public UILabel EndgameDescription;

	[Token(Token = "0x401767A")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Defeater;

	[Token(Token = "0x401767B")]
	[FieldOffset(Offset = "0x38")]
	public UILabel PlayerRank;

	[Token(Token = "0x401767C")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel TotalPlayersCount;

	[Token(Token = "0x401767D")]
	[FieldOffset(Offset = "0x40")]
	public UISprite PlayerRankTop;

	[Token(Token = "0x401767E")]
	[FieldOffset(Offset = "0x44")]
	public UISprite PlayerCharacter;

	[Token(Token = "0x401767F")]
	[FieldOffset(Offset = "0x48")]
	public UITexture BG_Shared;

	[Token(Token = "0x4017680")]
	[FieldOffset(Offset = "0x4C")]
	public UITexture GameTexture;

	[Token(Token = "0x4017681")]
	[FieldOffset(Offset = "0x50")]
	public UIGrid Teammates;

	[Token(Token = "0x4017682")]
	[FieldOffset(Offset = "0x54")]
	public UILabel MatchMode;

	[Token(Token = "0x4017683")]
	[FieldOffset(Offset = "0x58")]
	public UILabel GameMode;

	[Token(Token = "0x4017684")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel Map;

	[Token(Token = "0x6016D85")]
	[Address(RVA = "0x26907D0", Offset = "0x26907D0", VA = "0x26907D0")]
	public UIMatchResultZombieScreenshotView()
	{
	}

	[Token(Token = "0x6016D86")]
	[Address(RVA = "0x26907D8", Offset = "0x26907D8", VA = "0x26907D8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D87")]
	[Address(RVA = "0x2691028", Offset = "0x2691028", VA = "0x2691028")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
