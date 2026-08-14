using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028C0")]
public class UIHudWereWolvesTaskListItemController : UIEasyListItemController
{
	[Token(Token = "0x400FAD1")]
	[FieldOffset(Offset = "0x38")]
	private UIHudWereWolvesTaskListItemView m_View;

	[Token(Token = "0x400FAD2")]
	[FieldOffset(Offset = "0x3C")]
	private FPODNGHHILN m_Data;

	[Token(Token = "0x60100B6")]
	[Address(RVA = "0x2570AD0", Offset = "0x2570AD0", VA = "0x2570AD0")]
	public UIHudWereWolvesTaskListItemController()
	{
	}

	[Token(Token = "0x60100B7")]
	[Address(RVA = "0x2570AD8", Offset = "0x2570AD8", VA = "0x2570AD8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60100B8")]
	[Address(RVA = "0x2570B80", Offset = "0x2570B80", VA = "0x2570B80", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60100B9")]
	[Address(RVA = "0x2570C3C", Offset = "0x2570C3C", VA = "0x2570C3C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60100BA")]
	[Address(RVA = "0x2571114", Offset = "0x2571114", VA = "0x2571114")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
