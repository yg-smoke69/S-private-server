using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002B7B")]
public class UITrainingCampMsgItemController : UIEasyListItemController
{
	[Token(Token = "0x4010A5D")]
	[FieldOffset(Offset = "0x38")]
	private UITrainingCampMsgItemView m_View;

	[Token(Token = "0x4010A5E")]
	[FieldOffset(Offset = "0x3C")]
	private ChummyRequest m_Info;

	[Token(Token = "0x4010A5F")]
	[FieldOffset(Offset = "0x40")]
	private UIBaseProfileInfoController m_BaseInfo;

	[Token(Token = "0x4010A60")]
	[FieldOffset(Offset = "0x44")]
	private UIModelChummy m_ModelChummy;

	[Token(Token = "0x6011F51")]
	[Address(RVA = "0x1C1C4A8", Offset = "0x1C1C4A8", VA = "0x1C1C4A8")]
	public UITrainingCampMsgItemController()
	{
	}

	[Token(Token = "0x6011F52")]
	[Address(RVA = "0x1C1C4B0", Offset = "0x1C1C4B0", VA = "0x1C1C4B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011F53")]
	[Address(RVA = "0x1C1C554", Offset = "0x1C1C554", VA = "0x1C1C554", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011F54")]
	[Address(RVA = "0x1C1C844", Offset = "0x1C1C844", VA = "0x1C1C844", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011F55")]
	[Address(RVA = "0x1C1CBA4", Offset = "0x1C1CBA4", VA = "0x1C1CBA4")]
	private void RefreshMsgInfo()
	{
	}

	[Token(Token = "0x6011F56")]
	[Address(RVA = "0x1C1D3F0", Offset = "0x1C1D3F0", VA = "0x1C1D3F0")]
	private void OnClickCheckBtn()
	{
	}

	[Token(Token = "0x6011F57")]
	[Address(RVA = "0x1C1D7DC", Offset = "0x1C1D7DC", VA = "0x1C1D7DC")]
	private void OnClickAcceptBtn()
	{
	}

	[Token(Token = "0x6011F58")]
	[Address(RVA = "0x1C1D8B8", Offset = "0x1C1D8B8", VA = "0x1C1D8B8")]
	private void OnCountDownFinished()
	{
	}

	[Token(Token = "0x6011F59")]
	[Address(RVA = "0x1C1D964", Offset = "0x1C1D964", VA = "0x1C1D964")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
