using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20020A6")]
public class UIDebugConsoleOptionListItemController : UIEasyListItemController
{
	[Token(Token = "0x400CCA1")]
	[FieldOffset(Offset = "0x38")]
	public UIDebugConsoleOptionListController OptionListController;

	[Token(Token = "0x400CCA2")]
	[FieldOffset(Offset = "0x3C")]
	private UIDebugConsoleOptionListItemView m_View;

	[Token(Token = "0x400CCA3")]
	[FieldOffset(Offset = "0x40")]
	private string m_Option;

	[Token(Token = "0x600A862")]
	[Address(RVA = "0x2D79A04", Offset = "0x2D79A04", VA = "0x2D79A04")]
	public UIDebugConsoleOptionListItemController()
	{
	}

	[Token(Token = "0x600A863")]
	[Address(RVA = "0x2D79A0C", Offset = "0x2D79A0C", VA = "0x2D79A0C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A864")]
	[Address(RVA = "0x2D79AB4", Offset = "0x2D79AB4", VA = "0x2D79AB4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A865")]
	[Address(RVA = "0x2D79C10", Offset = "0x2D79C10", VA = "0x2D79C10", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A866")]
	[Address(RVA = "0x2D79D30", Offset = "0x2D79D30", VA = "0x2D79D30")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600A867")]
	[Address(RVA = "0x2D79D60", Offset = "0x2D79D60", VA = "0x2D79D60")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
