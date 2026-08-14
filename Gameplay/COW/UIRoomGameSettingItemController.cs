using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AE7")]
public class UIRoomGameSettingItemController : UIBaseController
{
	[Token(Token = "0x401076D")]
	[FieldOffset(Offset = "0x28")]
	private UIRoomGameSettingItemView m_View;

	[Token(Token = "0x601198E")]
	[Address(RVA = "0x23C0770", Offset = "0x23C0770", VA = "0x23C0770")]
	public UIRoomGameSettingItemController()
	{
	}

	[Token(Token = "0x601198F")]
	[Address(RVA = "0x23C07F4", Offset = "0x23C07F4", VA = "0x23C07F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011990")]
	[Address(RVA = "0x23C0898", Offset = "0x23C0898", VA = "0x23C0898", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011991")]
	[Address(RVA = "0x23C0954", Offset = "0x23C0954", VA = "0x23C0954")]
	public void SetData(string title, string text, int titleWidth, bool predictToolEnabel = false, bool predictToolDisable = false, bool trapEnable = false, bool trapDisable = false)
	{
	}

	[Token(Token = "0x6011992")]
	[Address(RVA = "0x23C0B8C", Offset = "0x23C0B8C", VA = "0x23C0B8C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
