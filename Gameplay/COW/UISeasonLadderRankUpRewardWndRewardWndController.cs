using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002179")]
public class UISeasonLadderRankUpRewardWndRewardWndController : CommonRewardWindowStyleBaseController
{
	[Token(Token = "0x400D21B")]
	[FieldOffset(Offset = "0x44")]
	public new CommonRewardWnd_BGStyle_SeasonLadderRankUPView m_View;

	[Token(Token = "0x400D21C")]
	[FieldOffset(Offset = "0x48")]
	private ELadderRankUpMatchType m_LadderRankUpMatchType;

	[Token(Token = "0x400D21D")]
	[FieldOffset(Offset = "0x4C")]
	private ResourceID m_BigIconRes;

	[Token(Token = "0x400D21E")]
	[FieldOffset(Offset = "0x50")]
	private string m_CurRankName;

	[Token(Token = "0x400D21F")]
	[FieldOffset(Offset = "0x54")]
	private uint m_CurRank;

	[Token(Token = "0x400D220")]
	[FieldOffset(Offset = "0x58")]
	private bool showKey;

	[Token(Token = "0x400D221")]
	[FieldOffset(Offset = "0x5C")]
	private UIModelMall m_ModelMall;

	[Token(Token = "0x400D222")]
	[FieldOffset(Offset = "0x60")]
	private GameObject effect;

	[Token(Token = "0x400D223")]
	[FieldOffset(Offset = "0x64")]
	private string GUIDEBTNSPRITENAME;

	[Token(Token = "0x400D224")]
	[FieldOffset(Offset = "0x68")]
	private string NORMALBTNSPRITENAME;

	[Token(Token = "0x600B16D")]
	[Address(RVA = "0x1A425A0", Offset = "0x1A425A0", VA = "0x1A425A0")]
	public UISeasonLadderRankUpRewardWndRewardWndController()
	{
	}

	[Token(Token = "0x600B16E")]
	[Address(RVA = "0x1A42720", Offset = "0x1A42720", VA = "0x1A42720")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B16F")]
	[Address(RVA = "0x1A427C8", Offset = "0x1A427C8", VA = "0x1A427C8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B170")]
	[Address(RVA = "0x1A42884", Offset = "0x1A42884", VA = "0x1A42884", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600B171")]
	[Address(RVA = "0x1A428E8", Offset = "0x1A428E8", VA = "0x1A428E8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B172")]
	[Address(RVA = "0x1A42A0C", Offset = "0x1A42A0C", VA = "0x1A42A0C", Slot = "31")]
	protected override string GetGuideBtnSpriteName()
	{
		return null;
	}

	[Token(Token = "0x600B173")]
	[Address(RVA = "0x1A42A64", Offset = "0x1A42A64", VA = "0x1A42A64", Slot = "32")]
	protected override string GetNormalBtnSpriteName()
	{
		return null;
	}

	[Token(Token = "0x600B174")]
	[Address(RVA = "0x1A42ABC", Offset = "0x1A42ABC", VA = "0x1A42ABC", Slot = "33")]
	protected override UIAtlas GetGuideBtnSpriteAtlas()
	{
		return null;
	}

	[Token(Token = "0x600B175")]
	[Address(RVA = "0x1A42C6C", Offset = "0x1A42C6C", VA = "0x1A42C6C", Slot = "34")]
	protected override UIAtlas GetNormalBtnSpriteAtlas()
	{
		return null;
	}

	[Token(Token = "0x600B176")]
	[Address(RVA = "0x1A42E1C", Offset = "0x1A42E1C", VA = "0x1A42E1C")]
	public void SetUIData(ELadderRankUpMatchType ladderRankUpMatchType, string rankName, ResourceID iconRes, uint rank)
	{
	}

	[Token(Token = "0x600B177")]
	[Address(RVA = "0x1A42EC0", Offset = "0x1A42EC0", VA = "0x1A42EC0")]
	private void SetLabelByRankAndToken()
	{
	}

	[Token(Token = "0x600B178")]
	[Address(RVA = "0x1A43814", Offset = "0x1A43814", VA = "0x1A43814")]
	private bool isReachRankLimitByRankType(ExchangeStoreItemDesc item)
	{
		return default(bool);
	}

	[Token(Token = "0x600B179")]
	[Address(RVA = "0x1A43344", Offset = "0x1A43344", VA = "0x1A43344")]
	private void RefreshUIView()
	{
	}

	[Token(Token = "0x600B17A")]
	[Address(RVA = "0x1A43B8C", Offset = "0x1A43B8C", VA = "0x1A43B8C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B17B")]
	[Address(RVA = "0x1A43B94", Offset = "0x1A43B94", VA = "0x1A43B94")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600B17C")]
	[Address(RVA = "0x1A43B9C", Offset = "0x1A43B9C", VA = "0x1A43B9C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600B17D")]
	[Address(RVA = "0x1A43BA4", Offset = "0x1A43BA4", VA = "0x1A43BA4")]
	public string _003C_003EiFixBaseProxy_GetGuideBtnSpriteName()
	{
		return null;
	}

	[Token(Token = "0x600B17E")]
	[Address(RVA = "0x1A43BAC", Offset = "0x1A43BAC", VA = "0x1A43BAC")]
	public string _003C_003EiFixBaseProxy_GetNormalBtnSpriteName()
	{
		return null;
	}

	[Token(Token = "0x600B17F")]
	[Address(RVA = "0x1A43BB4", Offset = "0x1A43BB4", VA = "0x1A43BB4")]
	public UIAtlas _003C_003EiFixBaseProxy_GetGuideBtnSpriteAtlas()
	{
		return null;
	}

	[Token(Token = "0x600B180")]
	[Address(RVA = "0x1A43BBC", Offset = "0x1A43BBC", VA = "0x1A43BBC")]
	public UIAtlas _003C_003EiFixBaseProxy_GetNormalBtnSpriteAtlas()
	{
		return null;
	}
}
