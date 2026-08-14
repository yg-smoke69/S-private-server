using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027C6")]
internal class UIHudMVEController : UIHudButtonBaseController
{
	[Token(Token = "0x400F597")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudMVEView m_View;

	[Token(Token = "0x600F615")]
	[Address(RVA = "0xFF79D0", Offset = "0xFF79D0", VA = "0xFF79D0")]
	public UIHudMVEController()
	{
	}

	[Token(Token = "0x600F616")]
	[Address(RVA = "0xFF79D8", Offset = "0xFF79D8", VA = "0xFF79D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F617")]
	[Address(RVA = "0xFF7A80", Offset = "0xFF7A80", VA = "0xFF7A80", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F618")]
	[Address(RVA = "0xFF7D34", Offset = "0xFF7D34", VA = "0xFF7D34", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F619")]
	[Address(RVA = "0xFF7F38", Offset = "0xFF7F38", VA = "0xFF7F38", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600F61A")]
	[Address(RVA = "0xFF7FDC", Offset = "0xFF7FDC", VA = "0xFF7FDC", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F61B")]
	[Address(RVA = "0xFF821C", Offset = "0xFF821C", VA = "0xFF821C")]
	private void Update()
	{
	}

	[Token(Token = "0x600F61C")]
	[Address(RVA = "0xFF87F0", Offset = "0xFF87F0", VA = "0xFF87F0")]
	private void OnEquipChange(object[] data)
	{
	}

	[Token(Token = "0x600F61D")]
	[Address(RVA = "0xFF88E4", Offset = "0xFF88E4", VA = "0xFF88E4")]
	private void OnSwitchObserver(object[] param)
	{
	}

	[Token(Token = "0x600F61E")]
	[Address(RVA = "0xFF803C", Offset = "0xFF803C", VA = "0xFF803C")]
	private void UpdateShowHide()
	{
	}

	[Token(Token = "0x600F61F")]
	[Address(RVA = "0xFF894C", Offset = "0xFF894C", VA = "0xFF894C")]
	private void OnEnergyChange(object[] data)
	{
	}

	[Token(Token = "0x600F620")]
	[Address(RVA = "0xFF8AF4", Offset = "0xFF8AF4", VA = "0xFF8AF4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F621")]
	[Address(RVA = "0xFF8AFC", Offset = "0xFF8AFC", VA = "0xFF8AFC")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F622")]
	[Address(RVA = "0xFF8B04", Offset = "0xFF8B04", VA = "0xFF8B04")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
