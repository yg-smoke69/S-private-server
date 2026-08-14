using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002662")]
public class UIGachaLimitItemController : UIBaseController
{
	[Token(Token = "0x2002663")]
	public enum ViewStage
	{
		[Token(Token = "0x400ED1F")]
		NORMAL,
		[Token(Token = "0x400ED20")]
		TRANSLUCENT,
		[Token(Token = "0x400ED21")]
		HIGHLIGHT,
		[Token(Token = "0x400ED22")]
		SELECTED,
		[Token(Token = "0x400ED23")]
		GET_REWARD
	}

	[Token(Token = "0x400ED18")]
	[FieldOffset(Offset = "0x28")]
	protected uint m_GachaID;

	[Token(Token = "0x400ED19")]
	[FieldOffset(Offset = "0x2C")]
	protected UIGachaLimitItemView m_View;

	[Token(Token = "0x400ED1A")]
	[FieldOffset(Offset = "0x30")]
	private GachaLimitItemState m_CurrentState;

	[Token(Token = "0x400ED1B")]
	[FieldOffset(Offset = "0x34")]
	protected uint m_gachaItemID;

	[Token(Token = "0x400ED1C")]
	[FieldOffset(Offset = "0x38")]
	protected int m_Idx;

	[Token(Token = "0x400ED1D")]
	[FieldOffset(Offset = "0x3C")]
	protected BaseItemInfo m_Info;

	[Token(Token = "0x17001181")]
	public int Index
	{
		[Token(Token = "0x600E58C")]
		[Address(RVA = "0x2A13CBC", Offset = "0x2A13CBC", VA = "0x2A13CBC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001182")]
	public BaseItemInfo Info
	{
		[Token(Token = "0x600E58D")]
		[Address(RVA = "0x2A13D14", Offset = "0x2A13D14", VA = "0x2A13D14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600E58B")]
	[Address(RVA = "0x2A13C38", Offset = "0x2A13C38", VA = "0x2A13C38")]
	public UIGachaLimitItemController()
	{
	}

	[Token(Token = "0x600E58E")]
	[Address(RVA = "0x2A13D6C", Offset = "0x2A13D6C", VA = "0x2A13D6C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E58F")]
	[Address(RVA = "0x2A13E10", Offset = "0x2A13E10", VA = "0x2A13E10", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E590")]
	[Address(RVA = "0x2A14734", Offset = "0x2A14734", VA = "0x2A14734")]
	public bool isOwnedorRemoved()
	{
		return default(bool);
	}

	[Token(Token = "0x600E591")]
	[Address(RVA = "0x2A147A4", Offset = "0x2A147A4", VA = "0x2A147A4")]
	public uint GetGachaItemID()
	{
		return default(uint);
	}

	[Token(Token = "0x600E592")]
	[Address(RVA = "0x2A14044", Offset = "0x2A14044", VA = "0x2A14044")]
	public void SetCurrentItemState(GachaLimitItemState state)
	{
	}

	[Token(Token = "0x600E593")]
	[Address(RVA = "0x2A147FC", Offset = "0x2A147FC", VA = "0x2A147FC")]
	private void OnBtnTipClick()
	{
	}

	[Token(Token = "0x600E594")]
	[Address(RVA = "0x2A1496C", Offset = "0x2A1496C", VA = "0x2A1496C")]
	private void OnChooseClick()
	{
	}

	[Token(Token = "0x600E595")]
	[Address(RVA = "0x2A14D5C", Offset = "0x2A14D5C", VA = "0x2A14D5C")]
	public void SetViewInfo(uint gachaID, int idx, GachaShowItem info, bool isShowDropUp = false)
	{
	}

	[Token(Token = "0x600E596")]
	[Address(RVA = "0x2A152F8", Offset = "0x2A152F8", VA = "0x2A152F8")]
	public void SetQualityBG(int Quality, UISprite QualityBG, UISprite QualityNameBG01)
	{
	}

	[Token(Token = "0x600E597")]
	[Address(RVA = "0x2A1583C", Offset = "0x2A1583C", VA = "0x2A1583C")]
	public void ShowView(ViewStage stage, float alpha = 1f)
	{
	}

	[Token(Token = "0x600E598")]
	[Address(RVA = "0x2A15B24", Offset = "0x2A15B24", VA = "0x2A15B24")]
	private void PlaySelectedAudio()
	{
	}

	[Token(Token = "0x600E599")]
	[Address(RVA = "0x2A15C3C", Offset = "0x2A15C3C", VA = "0x2A15C3C")]
	private void PlayGetRewardAudio()
	{
	}

	[Token(Token = "0x600E59A")]
	[Address(RVA = "0x2A15D54", Offset = "0x2A15D54", VA = "0x2A15D54", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E59B")]
	[Address(RVA = "0x2A15DB8", Offset = "0x2A15DB8", VA = "0x2A15DB8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E59C")]
	[Address(RVA = "0x2A15E1C", Offset = "0x2A15E1C", VA = "0x2A15E1C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E59D")]
	[Address(RVA = "0x2A15E24", Offset = "0x2A15E24", VA = "0x2A15E24")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E59E")]
	[Address(RVA = "0x2A15E2C", Offset = "0x2A15E2C", VA = "0x2A15E2C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
