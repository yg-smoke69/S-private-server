using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200382A")]
public class UILinkActivityPirateMapView : UIBaseView
{
	[Token(Token = "0x4016E52")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture Role;

	[Token(Token = "0x4016E53")]
	[FieldOffset(Offset = "0x18")]
	public UITexture Role_Shadow;

	[Token(Token = "0x4016E54")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnLink;

	[Token(Token = "0x4016E55")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid RewardList;

	[Token(Token = "0x4016E56")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Icon1;

	[Token(Token = "0x4016E57")]
	[FieldOffset(Offset = "0x28")]
	public UIButton Icon1Btn;

	[Token(Token = "0x4016E58")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Icon3;

	[Token(Token = "0x4016E59")]
	[FieldOffset(Offset = "0x30")]
	public UIButton Icon3Btn;

	[Token(Token = "0x4016E5A")]
	[FieldOffset(Offset = "0x34")]
	public UISprite Icon2;

	[Token(Token = "0x4016E5B")]
	[FieldOffset(Offset = "0x38")]
	public UIButton Icon2Btn;

	[Token(Token = "0x4016E5C")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite Icon4;

	[Token(Token = "0x4016E5D")]
	[FieldOffset(Offset = "0x40")]
	public UIButton Icon4Btn;

	[Token(Token = "0x4016E5E")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BtnClose;

	[Token(Token = "0x4016E5F")]
	[FieldOffset(Offset = "0x48")]
	public UILabel LabelWaitNext;

	[Token(Token = "0x4016E60")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BtnGoto;

	[Token(Token = "0x4016E61")]
	[FieldOffset(Offset = "0x50")]
	public UINetworkTexture CdnTexture;

	[Token(Token = "0x4016E62")]
	[FieldOffset(Offset = "0x54")]
	public GameObject Finished;

	[Token(Token = "0x4016E63")]
	[FieldOffset(Offset = "0x58")]
	public UILabel Days;

	[Token(Token = "0x4016E64")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton BtnBox;

	[Token(Token = "0x4016E65")]
	[FieldOffset(Offset = "0x60")]
	public UISprite BigRewardIcon;

	[Token(Token = "0x4016E66")]
	[FieldOffset(Offset = "0x64")]
	public UILabel FinishCounts;

	[Token(Token = "0x4016E67")]
	[FieldOffset(Offset = "0x68")]
	public GameObject BoxUnFinished;

	[Token(Token = "0x4016E68")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject BoxFinished;

	[Token(Token = "0x4016E69")]
	[FieldOffset(Offset = "0x70")]
	public GameObject BoxRewarded;

	[Token(Token = "0x6016C29")]
	[Address(RVA = "0x2559490", Offset = "0x2559490", VA = "0x2559490")]
	public UILinkActivityPirateMapView()
	{
	}

	[Token(Token = "0x6016C2A")]
	[Address(RVA = "0x2559498", Offset = "0x2559498", VA = "0x2559498", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C2B")]
	[Address(RVA = "0x2559EB0", Offset = "0x2559EB0", VA = "0x2559EB0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
