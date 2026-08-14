using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B6C")]
public class UITopUpEventActivityController : UIActivityContentController
{
	[Token(Token = "0x4010A0E")]
	[FieldOffset(Offset = "0x28")]
	private UITopUpEventController m_UITopUpEventController;

	[Token(Token = "0x6011E81")]
	[Address(RVA = "0x2AF18CC", Offset = "0x2AF18CC", VA = "0x2AF18CC")]
	public UITopUpEventActivityController()
	{
	}

	[Token(Token = "0x6011E82")]
	[Address(RVA = "0x2AF18D4", Offset = "0x2AF18D4", VA = "0x2AF18D4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011E83")]
	[Address(RVA = "0x2AF197C", Offset = "0x2AF197C", VA = "0x2AF197C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011E84")]
	[Address(RVA = "0x2AF1B3C", Offset = "0x2AF1B3C", VA = "0x2AF1B3C", Slot = "31")]
	public override void SetData(object data)
	{
	}

	[Token(Token = "0x6011E85")]
	[Address(RVA = "0x2AF38B4", Offset = "0x2AF38B4", VA = "0x2AF38B4", Slot = "34")]
	public override void OnVisibilityChange(bool isVisible, bool needRefresh)
	{
	}

	[Token(Token = "0x6011E86")]
	[Address(RVA = "0x2AF3BA4", Offset = "0x2AF3BA4", VA = "0x2AF3BA4", Slot = "35")]
	public override ResourceID GetBackGroundResroucesID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011E87")]
	[Address(RVA = "0x2AF3C50", Offset = "0x2AF3C50", VA = "0x2AF3C50")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011E88")]
	[Address(RVA = "0x2AF3C58", Offset = "0x2AF3C58", VA = "0x2AF3C58")]
	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	[Token(Token = "0x6011E89")]
	[Address(RVA = "0x2AF3C60", Offset = "0x2AF3C60", VA = "0x2AF3C60")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChange(bool P0, bool P1)
	{
	}

	[Token(Token = "0x6011E8A")]
	[Address(RVA = "0x2AF3C68", Offset = "0x2AF3C68", VA = "0x2AF3C68")]
	public ResourceID _003C_003EiFixBaseProxy_GetBackGroundResroucesID()
	{
		return default(ResourceID);
	}
}
