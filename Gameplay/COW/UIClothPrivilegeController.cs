using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002570")]
internal class UIClothPrivilegeController : UIBaseController
{
	[Token(Token = "0x400E7BD")]
	[FieldOffset(Offset = "0x28")]
	private UIClothPrivilegeItemView m_View;

	[Token(Token = "0x600DAD0")]
	[Address(RVA = "0x2CD1AE8", Offset = "0x2CD1AE8", VA = "0x2CD1AE8")]
	public UIClothPrivilegeController()
	{
	}

	[Token(Token = "0x600DAD1")]
	[Address(RVA = "0x2CD1B6C", Offset = "0x2CD1B6C", VA = "0x2CD1B6C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DAD2")]
	[Address(RVA = "0x2CD1C14", Offset = "0x2CD1C14", VA = "0x2CD1C14", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DAD3")]
	[Address(RVA = "0x2CD1CD0", Offset = "0x2CD1CD0", VA = "0x2CD1CD0")]
	public void SetData(TeamClothPrivilegeDetail privilege)
	{
	}

	[Token(Token = "0x600DAD4")]
	[Address(RVA = "0x2CD1E64", Offset = "0x2CD1E64", VA = "0x2CD1E64")]
	public void SetData(CollectionPrivilegeTagData privilege)
	{
	}

	[Token(Token = "0x600DAD5")]
	[Address(RVA = "0x2CD1FF8", Offset = "0x2CD1FF8", VA = "0x2CD1FF8")]
	public int GetHeight()
	{
		return default(int);
	}

	[Token(Token = "0x600DAD6")]
	[Address(RVA = "0x2CD2088", Offset = "0x2CD2088", VA = "0x2CD2088")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
