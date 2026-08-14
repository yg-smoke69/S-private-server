using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002504")]
public class UIChangeServerController : UIBaseController
{
	[Token(Token = "0x400E5DD")]
	[FieldOffset(Offset = "0x28")]
	private UIChangeServerView m_View;

	[Token(Token = "0x400E5DE")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<UIToggle, RegionSettingData> m_ToggleServerData;

	[Token(Token = "0x600D688")]
	[Address(RVA = "0x26289BC", Offset = "0x26289BC", VA = "0x26289BC")]
	public UIChangeServerController()
	{
	}

	[Token(Token = "0x600D689")]
	[Address(RVA = "0x2628A74", Offset = "0x2628A74", VA = "0x2628A74")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D68A")]
	[Address(RVA = "0x2628B18", Offset = "0x2628B18", VA = "0x2628B18", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D68B")]
	[Address(RVA = "0x2628CE8", Offset = "0x2628CE8", VA = "0x2628CE8")]
	public void SetServerList(int regionid)
	{
	}

	[Token(Token = "0x600D68C")]
	[Address(RVA = "0x26294A0", Offset = "0x26294A0", VA = "0x26294A0")]
	private void OnCloseClick()
	{
	}

	[Token(Token = "0x600D68D")]
	[Address(RVA = "0x2629504", Offset = "0x2629504", VA = "0x2629504")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x600D68E")]
	[Address(RVA = "0x2629830", Offset = "0x2629830", VA = "0x2629830")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
