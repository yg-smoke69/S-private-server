using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024A2")]
public class UIAutoPickUpSettingController : UISettingContentBase
{
	[Token(Token = "0x400E300")]
	[FieldOffset(Offset = "0x2C")]
	private UIAutoPickUpSettingView m_View;

	[Token(Token = "0x400E301")]
	public const string FastAutoPickup = "T_21_C_AUTOPICKUP_FAST";

	[Token(Token = "0x400E302")]
	public const string DefaultAutoPickup = "T_21_C_AUTOPICKUP_AVERAGE";

	[Token(Token = "0x400E303")]
	[FieldOffset(Offset = "0x30")]
	private bool isInit;

	[Token(Token = "0x600D193")]
	[Address(RVA = "0x1E72D68", Offset = "0x1E72D68", VA = "0x1E72D68")]
	public UIAutoPickUpSettingController()
	{
	}

	[Token(Token = "0x600D194")]
	[Address(RVA = "0x1E72D70", Offset = "0x1E72D70", VA = "0x1E72D70")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D195")]
	[Address(RVA = "0x1E72E18", Offset = "0x1E72E18", VA = "0x1E72E18", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D196")]
	[Address(RVA = "0x1E72EDC", Offset = "0x1E72EDC", VA = "0x1E72EDC")]
	private void InitItem()
	{
	}

	[Token(Token = "0x600D197")]
	[Address(RVA = "0x1E73A2C", Offset = "0x1E73A2C", VA = "0x1E73A2C")]
	private void ResetScrollViewWidth()
	{
	}

	[Token(Token = "0x600D198")]
	[Address(RVA = "0x1E73C48", Offset = "0x1E73C48", VA = "0x1E73C48")]
	private void OnToggleValueChange(int value)
	{
	}

	[Token(Token = "0x600D199")]
	[Address(RVA = "0x1E73D1C", Offset = "0x1E73D1C", VA = "0x1E73D1C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
