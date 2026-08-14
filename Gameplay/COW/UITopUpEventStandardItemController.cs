using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002B74")]
public class UITopUpEventStandardItemController : UIEasyListItemController
{
	[Token(Token = "0x4010A2E")]
	[FieldOffset(Offset = "0x38")]
	public UITopUpEventStandardItemView m_View;

	[Token(Token = "0x4010A2F")]
	[FieldOffset(Offset = "0x3C")]
	private AwardDesc m_AwardDesc;

	[Token(Token = "0x4010A30")]
	[FieldOffset(Offset = "0x40")]
	protected BaseItemInfo m_BaseItemInfo;

	[Token(Token = "0x4010A31")]
	[FieldOffset(Offset = "0x44")]
	private bool m_CanNotEquipTitleForAvartar;

	[Token(Token = "0x6011EC7")]
	[Address(RVA = "0x2AF89F0", Offset = "0x2AF89F0", VA = "0x2AF89F0")]
	public UITopUpEventStandardItemController()
	{
	}

	[Token(Token = "0x6011EC8")]
	[Address(RVA = "0x2AF89F8", Offset = "0x2AF89F8", VA = "0x2AF89F8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011EC9")]
	[Address(RVA = "0x2AF8A9C", Offset = "0x2AF8A9C", VA = "0x2AF8A9C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011ECA")]
	[Address(RVA = "0x2AF9344", Offset = "0x2AF9344", VA = "0x2AF9344")]
	public void SetData(AwardDesc newItemInfo)
	{
	}

	[Token(Token = "0x6011ECB")]
	[Address(RVA = "0x2AF97A8", Offset = "0x2AF97A8", VA = "0x2AF97A8")]
	public BaseItemInfo GetBaseInfo()
	{
		return null;
	}

	[Token(Token = "0x6011ECC")]
	[Address(RVA = "0x2AF9800", Offset = "0x2AF9800", VA = "0x2AF9800")]
	public AwardDesc GetAwardDesc()
	{
		return null;
	}

	[Token(Token = "0x6011ECD")]
	[Address(RVA = "0x2AF91D8", Offset = "0x2AF91D8", VA = "0x2AF91D8")]
	public void SetBtnClickEvent()
	{
	}

	[Token(Token = "0x6011ECE")]
	[Address(RVA = "0x2AF9858", Offset = "0x2AF9858", VA = "0x2AF9858")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x6011ECF")]
	[Address(RVA = "0x2AF9A00", Offset = "0x2AF9A00", VA = "0x2AF9A00")]
	public void SetBtnPreviewEvent()
	{
	}

	[Token(Token = "0x6011ED0")]
	[Address(RVA = "0x2AF9B6C", Offset = "0x2AF9B6C", VA = "0x2AF9B6C")]
	private void OnBtnPreviewClick()
	{
	}

	[Token(Token = "0x6011ED1")]
	[Address(RVA = "0x2AF9D4C", Offset = "0x2AF9D4C", VA = "0x2AF9D4C")]
	private void ShowItemPreview()
	{
	}

	[Token(Token = "0x6011ED2")]
	[Address(RVA = "0x2AF9E94", Offset = "0x2AF9E94", VA = "0x2AF9E94")]
	public void ShowItemName(bool show)
	{
	}

	[Token(Token = "0x6011ED3")]
	[Address(RVA = "0x2AF9F2C", Offset = "0x2AF9F2C", VA = "0x2AF9F2C")]
	public void SetBtnState(bool enable)
	{
	}

	[Token(Token = "0x6011ED4")]
	[Address(RVA = "0x2AF9FC4", Offset = "0x2AF9FC4", VA = "0x2AF9FC4", Slot = "37")]
	public virtual void SetQualityBG()
	{
	}

	[Token(Token = "0x6011ED5")]
	[Address(RVA = "0x2AFA134", Offset = "0x2AFA134", VA = "0x2AFA134")]
	public void SetNew(bool show)
	{
	}

	[Token(Token = "0x6011ED6")]
	[Address(RVA = "0x2AF8F78", Offset = "0x2AF8F78", VA = "0x2AF8F78")]
	public void SetLimitTitleState(bool show)
	{
	}

	[Token(Token = "0x6011ED7")]
	[Address(RVA = "0x2AF9010", Offset = "0x2AF9010", VA = "0x2AF9010")]
	public void SetClaimedState(bool show)
	{
	}

	[Token(Token = "0x6011ED8")]
	[Address(RVA = "0x2AFA1CC", Offset = "0x2AFA1CC", VA = "0x2AFA1CC")]
	public void SetOwnedState(bool show)
	{
	}

	[Token(Token = "0x6011ED9")]
	[Address(RVA = "0x2AFA264", Offset = "0x2AFA264", VA = "0x2AFA264")]
	public void SetCanNotEquipState(bool show, bool forAvatar = false)
	{
	}

	[Token(Token = "0x6011EDA")]
	[Address(RVA = "0x2AF9140", Offset = "0x2AF9140", VA = "0x2AF9140")]
	public void SetHighLightState(bool show)
	{
	}

	[Token(Token = "0x6011EDB")]
	[Address(RVA = "0x2AF90A8", Offset = "0x2AF90A8", VA = "0x2AF90A8")]
	public void SetGreyBGState(bool show)
	{
	}

	[Token(Token = "0x6011EDC")]
	[Address(RVA = "0x2AFA474", Offset = "0x2AFA474", VA = "0x2AFA474")]
	public void SetQualityBG(bool show)
	{
	}

	[Token(Token = "0x6011EDD")]
	[Address(RVA = "0x2AF948C", Offset = "0x2AF948C", VA = "0x2AF948C")]
	private void SetIPTag()
	{
	}

	[Token(Token = "0x6011EDE")]
	[Address(RVA = "0x2AFA52C", Offset = "0x2AFA52C", VA = "0x2AFA52C")]
	public void SetVFXState(bool value)
	{
	}

	[Token(Token = "0x6011EDF")]
	[Address(RVA = "0x2AFA5C4", Offset = "0x2AFA5C4", VA = "0x2AFA5C4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011EE0")]
	[Address(RVA = "0x2AFA76C", Offset = "0x2AFA76C", VA = "0x2AFA76C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
