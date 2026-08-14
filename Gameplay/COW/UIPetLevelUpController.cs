using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A5A")]
public class UIPetLevelUpController : UIPopupWindowController
{
	[Token(Token = "0x4010446")]
	[FieldOffset(Offset = "0x48")]
	private UIPetLevelUpView m_View;

	[Token(Token = "0x6011377")]
	[Address(RVA = "0x2C486D0", Offset = "0x2C486D0", VA = "0x2C486D0")]
	public UIPetLevelUpController()
	{
	}

	[Token(Token = "0x6011378")]
	[Address(RVA = "0x2C486D8", Offset = "0x2C486D8", VA = "0x2C486D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011379")]
	[Address(RVA = "0x2C48780", Offset = "0x2C48780", VA = "0x2C48780", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601137A")]
	[Address(RVA = "0x2C488DC", Offset = "0x2C488DC", VA = "0x2C488DC")]
	public void SetLevelData(uint before, uint after, uint pet_id)
	{
	}

	[Token(Token = "0x601137B")]
	[Address(RVA = "0x2C48AFC", Offset = "0x2C48AFC", VA = "0x2C48AFC")]
	private void OnOKClick()
	{
	}

	[Token(Token = "0x601137C")]
	[Address(RVA = "0x2C48D00", Offset = "0x2C48D00", VA = "0x2C48D00")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
