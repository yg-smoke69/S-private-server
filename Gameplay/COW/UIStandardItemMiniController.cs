using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023BE")]
public class UIStandardItemMiniController : UIEasyListItemController
{
	[Token(Token = "0x400DE6E")]
	[FieldOffset(Offset = "0x38")]
	public UIStandardItemMiniView m_View;

	[Token(Token = "0x400DE6F")]
	[FieldOffset(Offset = "0x3C")]
	public StatndardItemMiniData m_Data;

	[Token(Token = "0x400DE70")]
	[FieldOffset(Offset = "0x40")]
	public bool ForceFullScreenPreview;

	[Token(Token = "0x400DE71")]
	[FieldOffset(Offset = "0x41")]
	private bool m_NeedTween;

	[Token(Token = "0x600C942")]
	[Address(RVA = "0x206C39C", Offset = "0x206C39C", VA = "0x206C39C")]
	public UIStandardItemMiniController()
	{
	}

	[Token(Token = "0x600C943")]
	[Address(RVA = "0x206C3AC", Offset = "0x206C3AC", VA = "0x206C3AC", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C944")]
	[Address(RVA = "0x206C408", Offset = "0x206C408", VA = "0x206C408")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C945")]
	[Address(RVA = "0x206C4B0", Offset = "0x206C4B0", VA = "0x206C4B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C946")]
	[Address(RVA = "0x206C5B4", Offset = "0x206C5B4", VA = "0x206C5B4")]
	public void Init()
	{
	}

	[Token(Token = "0x600C947")]
	[Address(RVA = "0x206C620", Offset = "0x206C620", VA = "0x206C620")]
	public void SetStandItemMiniData(StatndardItemMiniData data, bool hasTween = true)
	{
	}

	[Token(Token = "0x600C948")]
	[Address(RVA = "0x206C6DC", Offset = "0x206C6DC", VA = "0x206C6DC")]
	public void RefreshView()
	{
	}

	[Token(Token = "0x600C949")]
	[Address(RVA = "0x206CD50", Offset = "0x206CD50", VA = "0x206CD50")]
	public UIDragScrollView GetItemDragView()
	{
		return null;
	}

	[Token(Token = "0x600C94A")]
	[Address(RVA = "0x206CDC0", Offset = "0x206CDC0", VA = "0x206CDC0")]
	public void UpdateQuantityLabel(string newCount)
	{
	}

	[Token(Token = "0x600C94B")]
	[Address(RVA = "0x206CE6C", Offset = "0x206CE6C", VA = "0x206CE6C")]
	public void SetFlowLightEnable(bool b)
	{
	}

	[Token(Token = "0x600C94C")]
	[Address(RVA = "0x206CF04", Offset = "0x206CF04", VA = "0x206CF04")]
	public void SetActiveQualityBg(bool active)
	{
	}

	[Token(Token = "0x600C94D")]
	[Address(RVA = "0x206D014", Offset = "0x206D014", VA = "0x206D014")]
	public void SetActiveQualityNameBg01(bool active)
	{
	}

	[Token(Token = "0x600C94E")]
	[Address(RVA = "0x206D124", Offset = "0x206D124", VA = "0x206D124", Slot = "37")]
	public virtual void SetQualityBG()
	{
	}

	[Token(Token = "0x600C94F")]
	[Address(RVA = "0x206C880", Offset = "0x206C880", VA = "0x206C880")]
	public void RefreshBaseItemView(BaseItemInfo info)
	{
	}

	[Token(Token = "0x600C950")]
	[Address(RVA = "0x206D2D0", Offset = "0x206D2D0", VA = "0x206D2D0")]
	public void SetBtnClickEvent(bool useFullScreen = true)
	{
	}

	[Token(Token = "0x600C951")]
	[Address(RVA = "0x206D47C", Offset = "0x206D47C", VA = "0x206D47C")]
	public void SetItemBtnState(bool show)
	{
	}

	[Token(Token = "0x600C952")]
	[Address(RVA = "0x206D534", Offset = "0x206D534", VA = "0x206D534")]
	public void SetCustomBtnClickEvent(Callback action)
	{
	}

	[Token(Token = "0x600C953")]
	[Address(RVA = "0x206D670", Offset = "0x206D670", VA = "0x206D670")]
	public void EnableItemBtn()
	{
	}

	[Token(Token = "0x600C954")]
	[Address(RVA = "0x206D700", Offset = "0x206D700", VA = "0x206D700")]
	public void DisableItemBtn()
	{
	}

	[Token(Token = "0x600C955")]
	[Address(RVA = "0x206D790", Offset = "0x206D790", VA = "0x206D790")]
	private void ShowItemPreview()
	{
	}

	[Token(Token = "0x600C956")]
	[Address(RVA = "0x206D8EC", Offset = "0x206D8EC", VA = "0x206D8EC")]
	private void ShowFullScreenPreview()
	{
	}

	[Token(Token = "0x600C957")]
	[Address(RVA = "0x206C928", Offset = "0x206C928", VA = "0x206C928")]
	public void SetLimitTitleState(bool show)
	{
	}

	[Token(Token = "0x600C958")]
	[Address(RVA = "0x206C9C0", Offset = "0x206C9C0", VA = "0x206C9C0")]
	public void SetClaimedState(bool show)
	{
	}

	[Token(Token = "0x600C959")]
	[Address(RVA = "0x206CB88", Offset = "0x206CB88", VA = "0x206CB88")]
	public void SetLadderGotState(bool show)
	{
	}

	[Token(Token = "0x600C95A")]
	[Address(RVA = "0x206CAF0", Offset = "0x206CAF0", VA = "0x206CAF0")]
	public void SetHighLightState(bool show)
	{
	}

	[Token(Token = "0x600C95B")]
	[Address(RVA = "0x206CA58", Offset = "0x206CA58", VA = "0x206CA58")]
	public void SetGreyBGState(bool show)
	{
	}

	[Token(Token = "0x600C95C")]
	[Address(RVA = "0x206CC20", Offset = "0x206CC20", VA = "0x206CC20")]
	public void SetOwnedState(bool show)
	{
	}

	[Token(Token = "0x600C95D")]
	[Address(RVA = "0x206CCB8", Offset = "0x206CCB8", VA = "0x206CCB8")]
	public void SetDownloadInfoState(bool show)
	{
	}

	[Token(Token = "0x600C95E")]
	[Address(RVA = "0x206DB90", Offset = "0x206DB90", VA = "0x206DB90")]
	public void SetCanNotEquipLabel(string key)
	{
	}

	[Token(Token = "0x600C95F")]
	[Address(RVA = "0x206DCEC", Offset = "0x206DCEC", VA = "0x206DCEC")]
	public void SetCanNotEquipState(bool show)
	{
	}

	[Token(Token = "0x600C960")]
	[Address(RVA = "0x206DDA4", Offset = "0x206DDA4", VA = "0x206DDA4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600C961")]
	[Address(RVA = "0x206DEF4", Offset = "0x206DEF4", VA = "0x206DEF4")]
	public void SetTweenEnable(bool enable)
	{
	}

	[Token(Token = "0x600C962")]
	[Address(RVA = "0x206DF90", Offset = "0x206DF90", VA = "0x206DF90")]
	public void SetQuantityIgnoreOne(bool ignore)
	{
	}

	[Token(Token = "0x600C963")]
	[Address(RVA = "0x206E01C", Offset = "0x206E01C", VA = "0x206E01C")]
	public void ChangeClickSound(string soundId)
	{
	}

	[Token(Token = "0x600C964")]
	[Address(RVA = "0x206E0A8", Offset = "0x206E0A8", VA = "0x206E0A8")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C965")]
	[Address(RVA = "0x206E0B0", Offset = "0x206E0B0", VA = "0x206E0B0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
