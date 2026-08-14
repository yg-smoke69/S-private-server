using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200296F")]
internal class UIMailReportReasonItemController : UIBaseController
{
	[Token(Token = "0x400FF5C")]
	[FieldOffset(Offset = "0x28")]
	private UIMailReportReasonItemView m_View;

	[Token(Token = "0x400FF5D")]
	[FieldOffset(Offset = "0x2C")]
	private List<UILabel> m_LabelList;

	[Token(Token = "0x60109D2")]
	[Address(RVA = "0x18E3E9C", Offset = "0x18E3E9C", VA = "0x18E3E9C")]
	public UIMailReportReasonItemController()
	{
	}

	[Token(Token = "0x60109D3")]
	[Address(RVA = "0x18E3F54", Offset = "0x18E3F54", VA = "0x18E3F54")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60109D4")]
	[Address(RVA = "0x18E3FF8", Offset = "0x18E3FF8", VA = "0x18E3FF8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60109D5")]
	[Address(RVA = "0x18E40B4", Offset = "0x18E40B4", VA = "0x18E40B4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x60109D6")]
	[Address(RVA = "0x18E4118", Offset = "0x18E4118", VA = "0x18E4118", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60109D7")]
	[Address(RVA = "0x18E417C", Offset = "0x18E417C", VA = "0x18E417C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60109D8")]
	[Address(RVA = "0x18E0D74", Offset = "0x18E0D74", VA = "0x18E0D74")]
	public void SetViewData(List<PunishRecord> punishRecords)
	{
	}

	[Token(Token = "0x60109D9")]
	[Address(RVA = "0x18E42D4", Offset = "0x18E42D4", VA = "0x18E42D4")]
	private string FixRichTextToBlack(string str)
	{
		return null;
	}

	[Token(Token = "0x60109DA")]
	[Address(RVA = "0x18E41E0", Offset = "0x18E41E0", VA = "0x18E41E0")]
	private string FixRichTextToRed(string str)
	{
		return null;
	}

	[Token(Token = "0x60109DB")]
	[Address(RVA = "0x18E43C8", Offset = "0x18E43C8", VA = "0x18E43C8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60109DC")]
	[Address(RVA = "0x18E43D0", Offset = "0x18E43D0", VA = "0x18E43D0")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x60109DD")]
	[Address(RVA = "0x18E43D8", Offset = "0x18E43D8", VA = "0x18E43D8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x60109DE")]
	[Address(RVA = "0x18E43E0", Offset = "0x18E43E0", VA = "0x18E43E0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
