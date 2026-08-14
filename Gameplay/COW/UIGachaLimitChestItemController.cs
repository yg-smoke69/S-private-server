using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002658")]
public class UIGachaLimitChestItemController : UIBaseController
{
	[Token(Token = "0x400ECD7")]
	[FieldOffset(Offset = "0x28")]
	private GachaShowItem m_gachaShowItemInfo;

	[Token(Token = "0x400ECD8")]
	[FieldOffset(Offset = "0x2C")]
	protected uint m_GachaID;

	[Token(Token = "0x400ECD9")]
	[FieldOffset(Offset = "0x30")]
	protected UIGachaLimitChestItemView m_View;

	[Token(Token = "0x400ECDA")]
	[FieldOffset(Offset = "0x34")]
	protected GachaLimitItemState m_CurrentState;

	[Token(Token = "0x400ECDB")]
	[FieldOffset(Offset = "0x38")]
	protected uint m_gachaItemID;

	[Token(Token = "0x400ECDC")]
	[FieldOffset(Offset = "0x3C")]
	protected int m_Idx;

	[Token(Token = "0x400ECDD")]
	[FieldOffset(Offset = "0x40")]
	protected BaseItemInfo m_Info;

	[Token(Token = "0x400ECDE")]
	[FieldOffset(Offset = "0x44")]
	private Action<int> m_onClickFunc;

	[Token(Token = "0x1700117D")]
	public GachaShowItem ShowItemInfo
	{
		[Token(Token = "0x600E513")]
		[Address(RVA = "0x2E81D00", Offset = "0x2E81D00", VA = "0x2E81D00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700117E")]
	public int Index
	{
		[Token(Token = "0x600E514")]
		[Address(RVA = "0x2E8406C", Offset = "0x2E8406C", VA = "0x2E8406C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700117F")]
	public BaseItemInfo Info
	{
		[Token(Token = "0x600E515")]
		[Address(RVA = "0x2E7E2BC", Offset = "0x2E7E2BC", VA = "0x2E7E2BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600E512")]
	[Address(RVA = "0x2E83FE8", Offset = "0x2E83FE8", VA = "0x2E83FE8")]
	public UIGachaLimitChestItemController()
	{
	}

	[Token(Token = "0x600E516")]
	[Address(RVA = "0x2E840C4", Offset = "0x2E840C4", VA = "0x2E840C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E517")]
	[Address(RVA = "0x2E8416C", Offset = "0x2E8416C", VA = "0x2E8416C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E518")]
	[Address(RVA = "0x2E7A68C", Offset = "0x2E7A68C", VA = "0x2E7A68C")]
	public void PlayerLightningEffect()
	{
	}

	[Token(Token = "0x600E519")]
	[Address(RVA = "0x2E7B98C", Offset = "0x2E7B98C", VA = "0x2E7B98C")]
	public void CloseLightningEffect()
	{
	}

	[Token(Token = "0x600E51A")]
	[Address(RVA = "0x2E84428", Offset = "0x2E84428", VA = "0x2E84428")]
	public uint GetGachaItemID()
	{
		return default(uint);
	}

	[Token(Token = "0x600E51B")]
	[Address(RVA = "0x2E81E28", Offset = "0x2E81E28", VA = "0x2E81E28")]
	public void RefreshState()
	{
	}

	[Token(Token = "0x600E51C")]
	[Address(RVA = "0x2E84480", Offset = "0x2E84480", VA = "0x2E84480")]
	protected void OnBtnTipClick()
	{
	}

	[Token(Token = "0x600E51D")]
	[Address(RVA = "0x2E7E314", Offset = "0x2E7E314", VA = "0x2E7E314")]
	public void SetViewInfo(uint gachaID, int idx, GachaShowItem info, bool isShowDropUp = false)
	{
	}

	[Token(Token = "0x600E51E")]
	[Address(RVA = "0x2E84538", Offset = "0x2E84538", VA = "0x2E84538")]
	public void SetQualityBG(int Quality)
	{
	}

	[Token(Token = "0x600E51F")]
	[Address(RVA = "0x2E84880", Offset = "0x2E84880", VA = "0x2E84880")]
	protected void PlaySelectedAudio()
	{
	}

	[Token(Token = "0x600E520")]
	[Address(RVA = "0x2E84998", Offset = "0x2E84998", VA = "0x2E84998")]
	protected void PlayGetRewardAudio()
	{
	}

	[Token(Token = "0x600E521")]
	[Address(RVA = "0x2E84AB0", Offset = "0x2E84AB0", VA = "0x2E84AB0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E522")]
	[Address(RVA = "0x2E84B14", Offset = "0x2E84B14", VA = "0x2E84B14", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E523")]
	[Address(RVA = "0x2E7A354", Offset = "0x2E7A354", VA = "0x2E7A354")]
	public void InitOnClickFunc(Action<int> action)
	{
	}

	[Token(Token = "0x600E524")]
	[Address(RVA = "0x2E7E0F8", Offset = "0x2E7E0F8", VA = "0x2E7E0F8")]
	public void PlayLoadingEndAniEffect()
	{
	}

	[Token(Token = "0x600E525")]
	[Address(RVA = "0x2E7D07C", Offset = "0x2E7D07C", VA = "0x2E7D07C")]
	public void StopLoadingEndAniEffect()
	{
	}

	[Token(Token = "0x600E526")]
	[Address(RVA = "0x2E84B78", Offset = "0x2E84B78", VA = "0x2E84B78")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E527")]
	[Address(RVA = "0x2E84B80", Offset = "0x2E84B80", VA = "0x2E84B80")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E528")]
	[Address(RVA = "0x2E84B88", Offset = "0x2E84B88", VA = "0x2E84B88")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
