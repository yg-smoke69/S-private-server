using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200389A")]
public class UIMatchResultScreenshotView : UIBaseView
{
	[Token(Token = "0x4017638")]
	[FieldOffset(Offset = "0x14")]
	public ShareCamera ShareCameraObject;

	[Token(Token = "0x4017639")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ShareUI;

	[Token(Token = "0x401763A")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture HeadshotRemote;

	[Token(Token = "0x401763B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HeadshotDefault;

	[Token(Token = "0x401763C")]
	[FieldOffset(Offset = "0x24")]
	public UIEffectSprite HeadshotLocal;

	[Token(Token = "0x401763D")]
	[FieldOffset(Offset = "0x28")]
	public UISprite callsign;

	[Token(Token = "0x401763E")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel PlayerID;

	[Token(Token = "0x401763F")]
	[FieldOffset(Offset = "0x30")]
	public UILabel PlayerNickname;

	[Token(Token = "0x4017640")]
	[FieldOffset(Offset = "0x34")]
	public UILabel EndgameDescription;

	[Token(Token = "0x4017641")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Defeater;

	[Token(Token = "0x4017642")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel WeaponDefeatedWith;

	[Token(Token = "0x4017643")]
	[FieldOffset(Offset = "0x40")]
	public UILabel GameMode;

	[Token(Token = "0x4017644")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Map;

	[Token(Token = "0x4017645")]
	[FieldOffset(Offset = "0x48")]
	public UILabel PlayerRank;

	[Token(Token = "0x4017646")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel TotalPlayersCount;

	[Token(Token = "0x4017647")]
	[FieldOffset(Offset = "0x50")]
	public UISprite SeasonRankIcon;

	[Token(Token = "0x4017648")]
	[FieldOffset(Offset = "0x54")]
	public UILabel SeasonRank;

	[Token(Token = "0x4017649")]
	[FieldOffset(Offset = "0x58")]
	public GameObject rankcolor;

	[Token(Token = "0x401764A")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject bronze;

	[Token(Token = "0x401764B")]
	[FieldOffset(Offset = "0x60")]
	public GameObject silver;

	[Token(Token = "0x401764C")]
	[FieldOffset(Offset = "0x64")]
	public GameObject gold;

	[Token(Token = "0x401764D")]
	[FieldOffset(Offset = "0x68")]
	public GameObject platinum;

	[Token(Token = "0x401764E")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject diamon;

	[Token(Token = "0x401764F")]
	[FieldOffset(Offset = "0x70")]
	public GameObject king;

	[Token(Token = "0x4017650")]
	[FieldOffset(Offset = "0x74")]
	public GameObject peek;

	[Token(Token = "0x4017651")]
	[FieldOffset(Offset = "0x78")]
	public UILabel playerKill;

	[Token(Token = "0x4017652")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel playerDamage;

	[Token(Token = "0x4017653")]
	[FieldOffset(Offset = "0x80")]
	public UILabel playerSurviveTime;

	[Token(Token = "0x4017654")]
	[FieldOffset(Offset = "0x84")]
	public UITable Team;

	[Token(Token = "0x4017655")]
	[FieldOffset(Offset = "0x88")]
	public GameObject Teammate1;

	[Token(Token = "0x4017656")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel teammate1Kill;

	[Token(Token = "0x4017657")]
	[FieldOffset(Offset = "0x90")]
	public UILabel teammate1Name;

	[Token(Token = "0x4017658")]
	[FieldOffset(Offset = "0x94")]
	public GameObject Teammate2;

	[Token(Token = "0x4017659")]
	[FieldOffset(Offset = "0x98")]
	public UILabel teammate2Kill;

	[Token(Token = "0x401765A")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel teammate2Name;

	[Token(Token = "0x401765B")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject Teammate3;

	[Token(Token = "0x401765C")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel teammate3Kill;

	[Token(Token = "0x401765D")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel teammate3Name;

	[Token(Token = "0x401765E")]
	[FieldOffset(Offset = "0xAC")]
	public UITexture PlayerAvatar;

	[Token(Token = "0x401765F")]
	[FieldOffset(Offset = "0xB0")]
	public UITexture BG_Shared;

	[Token(Token = "0x6016D79")]
	[Address(RVA = "0x268920C", Offset = "0x268920C", VA = "0x268920C")]
	public UIMatchResultScreenshotView()
	{
	}

	[Token(Token = "0x6016D7A")]
	[Address(RVA = "0x2689214", Offset = "0x2689214", VA = "0x2689214", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D7B")]
	[Address(RVA = "0x268A1C0", Offset = "0x268A1C0", VA = "0x268A1C0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
