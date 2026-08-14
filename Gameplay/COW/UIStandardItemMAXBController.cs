using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023BB")]
public class UIStandardItemMAXBController : UIEasyListItemController
{
	[Token(Token = "0x400DE61")]
	[FieldOffset(Offset = "0x38")]
	public UIStandardItemMAXBView m_View;

	[Token(Token = "0x400DE62")]
	[FieldOffset(Offset = "0x3C")]
	protected BaseItemInfo m_BaseItemInfo;

	[Token(Token = "0x400DE63")]
	[FieldOffset(Offset = "0x40")]
	private bool m_CanNotEquipTitleForAvartar;

	[Token(Token = "0x600C914")]
	[Address(RVA = "0x20673C8", Offset = "0x20673C8", VA = "0x20673C8")]
	public UIStandardItemMAXBController()
	{
	}

	[Token(Token = "0x600C915")]
	[Address(RVA = "0x20673D0", Offset = "0x20673D0", VA = "0x20673D0", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C916")]
	[Address(RVA = "0x206742C", Offset = "0x206742C", VA = "0x206742C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C917")]
	[Address(RVA = "0x20674D0", Offset = "0x20674D0", VA = "0x20674D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C918")]
	[Address(RVA = "0x2067D60", Offset = "0x2067D60", VA = "0x2067D60")]
	public void SetData(BaseItemInfo newItemInfo)
	{
	}

	[Token(Token = "0x600C919")]
	[Address(RVA = "0x206853C", Offset = "0x206853C", VA = "0x206853C")]
	public BaseItemInfo GetBaseInfo()
	{
		return null;
	}

	[Token(Token = "0x600C91A")]
	[Address(RVA = "0x2068594", Offset = "0x2068594", VA = "0x2068594")]
	public void SetBtnClickEvent(Callback callback)
	{
	}

	[Token(Token = "0x600C91B")]
	[Address(RVA = "0x20686D0", Offset = "0x20686D0", VA = "0x20686D0")]
	public void SetBtnPreviewEvent()
	{
	}

	[Token(Token = "0x600C91C")]
	[Address(RVA = "0x206883C", Offset = "0x206883C", VA = "0x206883C")]
	private void OnBtnPreviewClick()
	{
	}

	[Token(Token = "0x600C91D")]
	[Address(RVA = "0x2068A98", Offset = "0x2068A98", VA = "0x2068A98")]
	private void ShowItemPreview()
	{
	}

	[Token(Token = "0x600C91E")]
	[Address(RVA = "0x2068BE0", Offset = "0x2068BE0", VA = "0x2068BE0")]
	public void ShowItemName(bool show)
	{
	}

	[Token(Token = "0x600C91F")]
	[Address(RVA = "0x2068C78", Offset = "0x2068C78", VA = "0x2068C78")]
	public void SetItemNameOverflow(Overflow overflow)
	{
	}

	[Token(Token = "0x600C920")]
	[Address(RVA = "0x2068D24", Offset = "0x2068D24", VA = "0x2068D24")]
	public void SetItemNameColor(Color color)
	{
	}

	[Token(Token = "0x600C921")]
	[Address(RVA = "0x2068E00", Offset = "0x2068E00", VA = "0x2068E00")]
	public void SetBtnState(bool enable)
	{
	}

	[Token(Token = "0x600C922")]
	[Address(RVA = "0x2068E98", Offset = "0x2068E98", VA = "0x2068E98", Slot = "37")]
	public virtual void SetQualityBG()
	{
	}

	[Token(Token = "0x600C923")]
	[Address(RVA = "0x2069008", Offset = "0x2069008", VA = "0x2069008")]
	public void SetNew(bool show)
	{
	}

	[Token(Token = "0x600C924")]
	[Address(RVA = "0x2067B00", Offset = "0x2067B00", VA = "0x2067B00")]
	public void SetLimitTitleState(bool show)
	{
	}

	[Token(Token = "0x600C925")]
	[Address(RVA = "0x2067B98", Offset = "0x2067B98", VA = "0x2067B98")]
	public void SetClaimedState(bool show)
	{
	}

	[Token(Token = "0x600C926")]
	[Address(RVA = "0x20690A0", Offset = "0x20690A0", VA = "0x20690A0")]
	public void SetOwnedState(bool show)
	{
	}

	[Token(Token = "0x600C927")]
	[Address(RVA = "0x2069138", Offset = "0x2069138", VA = "0x2069138")]
	public void SetCanNotEquipState(bool show, bool forAvatar = false)
	{
	}

	[Token(Token = "0x600C928")]
	[Address(RVA = "0x2067CC8", Offset = "0x2067CC8", VA = "0x2067CC8")]
	public void SetHighLightState(bool show)
	{
	}

	[Token(Token = "0x600C929")]
	[Address(RVA = "0x2067C30", Offset = "0x2067C30", VA = "0x2067C30")]
	public void SetGreyBGState(bool show)
	{
	}

	[Token(Token = "0x600C92A")]
	[Address(RVA = "0x2069348", Offset = "0x2069348", VA = "0x2069348")]
	public void SetQualityBG(bool show)
	{
	}

	[Token(Token = "0x600C92B")]
	[Address(RVA = "0x2067E3C", Offset = "0x2067E3C", VA = "0x2067E3C")]
	private void SetIPTag()
	{
	}

	[Token(Token = "0x600C92C")]
	[Address(RVA = "0x2069400", Offset = "0x2069400", VA = "0x2069400")]
	public void SetLinkTag()
	{
	}

	[Token(Token = "0x600C92D")]
	[Address(RVA = "0x20694B0", Offset = "0x20694B0", VA = "0x20694B0")]
	public void SetTokenTag(uint type)
	{
	}

	[Token(Token = "0x600C92E")]
	[Address(RVA = "0x2069638", Offset = "0x2069638", VA = "0x2069638")]
	public void SetTokenBtnClickEvent(Callback callback)
	{
	}

	[Token(Token = "0x600C92F")]
	[Address(RVA = "0x206973C", Offset = "0x206973C", VA = "0x206973C")]
	public void SetVFXState(bool value)
	{
	}

	[Token(Token = "0x600C930")]
	[Address(RVA = "0x20697D4", Offset = "0x20697D4", VA = "0x20697D4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600C931")]
	[Address(RVA = "0x206998C", Offset = "0x206998C", VA = "0x206998C")]
	public void SetHotFixDownload(bool show)
	{
	}

	[Token(Token = "0x600C932")]
	[Address(RVA = "0x2069AA0", Offset = "0x2069AA0", VA = "0x2069AA0")]
	public void SetHotFixDownloadCenter(bool show)
	{
	}

	[Token(Token = "0x600C933")]
	[Address(RVA = "0x2068158", Offset = "0x2068158", VA = "0x2068158")]
	public void ShowNotReadyLabel(uint id)
	{
	}

	[Token(Token = "0x600C934")]
	[Address(RVA = "0x2069B58", Offset = "0x2069B58", VA = "0x2069B58")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C935")]
	[Address(RVA = "0x2069B60", Offset = "0x2069B60", VA = "0x2069B60")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
