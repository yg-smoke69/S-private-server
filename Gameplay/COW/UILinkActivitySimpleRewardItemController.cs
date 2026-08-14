using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200218E")]
public abstract class UILinkActivitySimpleRewardItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x400D260")]
	[FieldOffset(Offset = "0x28")]
	private UILinkActivitySimpleRewardItemView m_View;

	[Token(Token = "0x400D261")]
	[FieldOffset(Offset = "0x2C")]
	private BaseItemInfo m_Data;

	[Token(Token = "0x600B208")]
	[Address(RVA = "0x254F398", Offset = "0x254F398", VA = "0x254F398")]
	protected UILinkActivitySimpleRewardItemController()
	{
	}

	[Token(Token = "0x600B209")]
	[Address(RVA = "0x2559EB8", Offset = "0x2559EB8", VA = "0x2559EB8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B20A")]
	[Address(RVA = "0x2559F88", Offset = "0x2559F88", VA = "0x2559F88", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B20B")]
	[Address(RVA = "0x255A044", Offset = "0x255A044", VA = "0x255A044", Slot = "31")]
	public void SetBaseItemInfo(BaseItemInfo data)
	{
	}

	[Token(Token = "0x600B20C")]
	[Address(RVA = "0x255A0B0", Offset = "0x255A0B0", VA = "0x255A0B0")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x600B20D")]
	[Address(RVA = "0x254ED20", Offset = "0x254ED20", VA = "0x254ED20")]
	public void TintIconColor(uint val)
	{
	}

	[Token(Token = "0x600B20E")]
	[Address(RVA = "0x255A158", Offset = "0x255A158", VA = "0x255A158")]
	private void OnRewardBtnClick()
	{
	}

	[Token(Token = "0x600B20F")]
	[Address(RVA = "0x255A2A0", Offset = "0x255A2A0", VA = "0x255A2A0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
