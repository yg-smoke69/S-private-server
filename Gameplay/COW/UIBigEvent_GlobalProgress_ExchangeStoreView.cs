using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033EE")]
public class UIBigEvent_GlobalProgress_ExchangeStoreView : UIBaseView
{
	[Token(Token = "0x4013F93")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture StoreBGCDN;

	[Token(Token = "0x4013F94")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture StoreTitleCDN;

	[Token(Token = "0x4013F95")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnRule;

	[Token(Token = "0x4013F96")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelDate;

	[Token(Token = "0x4013F97")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnToken;

	[Token(Token = "0x4013F98")]
	[FieldOffset(Offset = "0x28")]
	public UISprite TokenIcon;

	[Token(Token = "0x4013F99")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TokenNum;

	[Token(Token = "0x4013F9A")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnClose;

	[Token(Token = "0x4013F9B")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ToggleClassic;

	[Token(Token = "0x4013F9C")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ToggleSpecial;

	[Token(Token = "0x4013F9D")]
	[FieldOffset(Offset = "0x3C")]
	public UIToggleButton ToggleBtnClassic;

	[Token(Token = "0x4013F9E")]
	[FieldOffset(Offset = "0x40")]
	public UINetworkTexture ToggleClassicBGCDN;

	[Token(Token = "0x4013F9F")]
	[FieldOffset(Offset = "0x44")]
	public UITexture ToggleClassicBG;

	[Token(Token = "0x4013FA0")]
	[FieldOffset(Offset = "0x48")]
	public UINetworkTexture ToggleSpecialBGCDN;

	[Token(Token = "0x4013FA1")]
	[FieldOffset(Offset = "0x4C")]
	public UITexture ToggleSpecialBG;

	[Token(Token = "0x4013FA2")]
	[FieldOffset(Offset = "0x50")]
	public UIToggleButton ToggleBtnSpecial;

	[Token(Token = "0x4013FA3")]
	[FieldOffset(Offset = "0x54")]
	public GameObject LockClassic;

	[Token(Token = "0x4013FA4")]
	[FieldOffset(Offset = "0x58")]
	public GameObject LockSpecial;

	[Token(Token = "0x4013FA5")]
	[FieldOffset(Offset = "0x5C")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4013FA6")]
	[FieldOffset(Offset = "0x60")]
	public UIEasyList EasyList;

	[Token(Token = "0x4013FA7")]
	[FieldOffset(Offset = "0x64")]
	public UIButton RedTipsOnOffBtn;

	[Token(Token = "0x4013FA8")]
	[FieldOffset(Offset = "0x68")]
	public GameObject Select;

	[Token(Token = "0x4013FA9")]
	[FieldOffset(Offset = "0x6C")]
	public Transform TokenTipsContainer;

	[Token(Token = "0x4013FAA")]
	[FieldOffset(Offset = "0x70")]
	public GameObject LeftContainer;

	[Token(Token = "0x4013FAB")]
	[FieldOffset(Offset = "0x74")]
	public UINetworkTexture ToggleClassicLogoCDN;

	[Token(Token = "0x4013FAC")]
	[FieldOffset(Offset = "0x78")]
	public UINetworkTexture ToggleSpecialLogoCDN;

	[Token(Token = "0x4013FAD")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel ClassicSelectLabel;

	[Token(Token = "0x4013FAE")]
	[FieldOffset(Offset = "0x80")]
	public UILabel SpecialSelectLabel;

	[Token(Token = "0x4013FAF")]
	[FieldOffset(Offset = "0x84")]
	public GameObject defaultView;

	[Token(Token = "0x4013FB0")]
	[FieldOffset(Offset = "0x88")]
	public GameObject content;

	[Token(Token = "0x4013FB1")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton BtnCloseDefault;

	[Token(Token = "0x4013FB2")]
	[FieldOffset(Offset = "0x90")]
	public UISprite IconDate;

	[Token(Token = "0x4013FB3")]
	[FieldOffset(Offset = "0x94")]
	public UILabel ClassicUnSelectLabel;

	[Token(Token = "0x4013FB4")]
	[FieldOffset(Offset = "0x98")]
	public UILabel SpecialUnSelectLabel;

	[Token(Token = "0x4013FB5")]
	[FieldOffset(Offset = "0x9C")]
	public UINetworkTexture TextureSpecialBubble;

	[Token(Token = "0x4013FB6")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel SpecialStoreOpenDateLabel;

	[Token(Token = "0x6015F7E")]
	[Address(RVA = "0x3027680", Offset = "0x3027680", VA = "0x3027680")]
	public UIBigEvent_GlobalProgress_ExchangeStoreView()
	{
	}

	[Token(Token = "0x6015F7F")]
	[Address(RVA = "0x3027688", Offset = "0x3027688", VA = "0x3027688", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F80")]
	[Address(RVA = "0x30284C8", Offset = "0x30284C8", VA = "0x30284C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
