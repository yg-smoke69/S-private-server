using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BCB")]
internal class UIVersionController : UIBaseController
{
	[Token(Token = "0x4010BAC")]
	[FieldOffset(Offset = "0x28")]
	private UIVersionView m_View;

	[Token(Token = "0x60121EE")]
	[Address(RVA = "0x2844B08", Offset = "0x2844B08", VA = "0x2844B08")]
	public UIVersionController()
	{
	}

	[Token(Token = "0x60121EF")]
	[Address(RVA = "0x2844B8C", Offset = "0x2844B8C", VA = "0x2844B8C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60121F0")]
	[Address(RVA = "0x2844C30", Offset = "0x2844C30", VA = "0x2844C30", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60121F1")]
	[Address(RVA = "0x2844D88", Offset = "0x2844D88", VA = "0x2844D88")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
