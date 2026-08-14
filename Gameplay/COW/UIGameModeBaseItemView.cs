using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035A2")]
internal class UIGameModeBaseItemView : MonoBehaviour
{
	[Token(Token = "0x401564C")]
	[FieldOffset(Offset = "0xC")]
	public UIToggleButton ModeBtn;

	[Token(Token = "0x401564D")]
	[FieldOffset(Offset = "0x10")]
	public Transform ModeInfo;

	[Token(Token = "0x401564E")]
	[FieldOffset(Offset = "0x14")]
	public UISprite ModeSprite;

	[Token(Token = "0x401564F")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x4015650")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture UINetworkTexture02;

	[Token(Token = "0x4015651")]
	[FieldOffset(Offset = "0x20")]
	public Transform TopLeft;

	[Token(Token = "0x4015652")]
	[FieldOffset(Offset = "0x24")]
	public UITexture clippedNetworkTexture;

	[Token(Token = "0x4015653")]
	[FieldOffset(Offset = "0x28")]
	public GameObject clickEffect;

	[Token(Token = "0x4015654")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject download;

	[Token(Token = "0x4015655")]
	[FieldOffset(Offset = "0x30")]
	public UIPanel liveEffectsPanel;

	[Token(Token = "0x4015656")]
	[FieldOffset(Offset = "0x34")]
	public GameObject bg;

	[Token(Token = "0x4015657")]
	[FieldOffset(Offset = "0x38")]
	public UIPanel panelOverLiveEffects;

	[Token(Token = "0x4015658")]
	[FieldOffset(Offset = "0x3C")]
	public UIPanel Lock;

	[Token(Token = "0x4015659")]
	[FieldOffset(Offset = "0x40")]
	public UILabel LevelLabel;

	[Token(Token = "0x401565A")]
	[FieldOffset(Offset = "0x44")]
	public GameObject staticPic;

	[Token(Token = "0x401565B")]
	[FieldOffset(Offset = "0x48")]
	public GameObject HLEffect;

	[Token(Token = "0x401565C")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject GuideTip;

	[Token(Token = "0x6016496")]
	[Address(RVA = "0x24665D8", Offset = "0x24665D8", VA = "0x24665D8")]
	public UIGameModeBaseItemView()
	{
	}
}
