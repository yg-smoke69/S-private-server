using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002193")]
public class LuckyWheelShareInfoController : UIBaseController
{
	[Token(Token = "0x400D268")]
	[FieldOffset(Offset = "0x28")]
	private LuckyWheelShareInfoView m_View;

	[Token(Token = "0x400D269")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelLuckyWheel m_Model;

	[Token(Token = "0x400D26A")]
	[FieldOffset(Offset = "0x30")]
	private UIModelCDNAd m_CDNModel;

	[Token(Token = "0x600B223")]
	[Address(RVA = "0x152F340", Offset = "0x152F340", VA = "0x152F340")]
	public LuckyWheelShareInfoController()
	{
	}

	[Token(Token = "0x600B224")]
	[Address(RVA = "0x152F3C4", Offset = "0x152F3C4", VA = "0x152F3C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B225")]
	[Address(RVA = "0x152F46C", Offset = "0x152F46C", VA = "0x152F46C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B226")]
	[Address(RVA = "0x152FCC0", Offset = "0x152FCC0", VA = "0x152FCC0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600B227")]
	[Address(RVA = "0x152F5E4", Offset = "0x152F5E4", VA = "0x152F5E4")]
	private void SetShareInfo()
	{
	}

	[Token(Token = "0x600B228")]
	[Address(RVA = "0x152FD40", Offset = "0x152FD40", VA = "0x152FD40")]
	private void OnSuccessfulLoadCDN()
	{
	}

	[Token(Token = "0x600B229")]
	[Address(RVA = "0x152FDD0", Offset = "0x152FDD0", VA = "0x152FDD0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B22A")]
	[Address(RVA = "0x152FDD8", Offset = "0x152FDD8", VA = "0x152FDD8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
