using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C12")]
public class UIWeaponSkinUpgraderGunPickController : UINavigationController, _Attribute
{
	[Token(Token = "0x4010D48")]
	[FieldOffset(Offset = "0x68")]
	private UIWeaponSkinUpgraderGunPickView m_View;

	[Token(Token = "0x4010D49")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	[Token(Token = "0x4010D4A")]
	private const int m_MinShowGunItem = 6;

	[Token(Token = "0x601253F")]
	[Address(RVA = "0x1B6F8F0", Offset = "0x1B6F8F0", VA = "0x1B6F8F0")]
	public UIWeaponSkinUpgraderGunPickController()
	{
	}

	[Token(Token = "0x6012540")]
	[Address(RVA = "0x1B6F974", Offset = "0x1B6F974", VA = "0x1B6F974")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012541")]
	[Address(RVA = "0x1B6FA18", Offset = "0x1B6FA18", VA = "0x1B6FA18", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012542")]
	[Address(RVA = "0x1B6FC38", Offset = "0x1B6FC38", VA = "0x1B6FC38")]
	private void OnCloseBtn()
	{
	}

	[Token(Token = "0x6012543")]
	[Address(RVA = "0x1B6FD44", Offset = "0x1B6FD44", VA = "0x1B6FD44", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6012544")]
	[Address(RVA = "0x1B6FE58", Offset = "0x1B6FE58", VA = "0x1B6FE58", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6012545")]
	[Address(RVA = "0x1B6FEE0", Offset = "0x1B6FEE0", VA = "0x1B6FEE0", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6012546")]
	[Address(RVA = "0x1B7097C", Offset = "0x1B7097C", VA = "0x1B7097C", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6012547")]
	[Address(RVA = "0x1B6FDF8", Offset = "0x1B6FDF8", VA = "0x1B6FDF8")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6012548")]
	[Address(RVA = "0x1B6FFAC", Offset = "0x1B6FFAC", VA = "0x1B6FFAC")]
	private void RefreshGunPickList()
	{
	}

	[Token(Token = "0x6012549")]
	[Address(RVA = "0x1B71AC8", Offset = "0x1B71AC8", VA = "0x1B71AC8")]
	private int _003CRefreshGunPickList_003Em__0(SkinOwnAndOpenInfo x, SkinOwnAndOpenInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x601254A")]
	[Address(RVA = "0x1B71C84", Offset = "0x1B71C84", VA = "0x1B71C84")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601254B")]
	[Address(RVA = "0x1B71C8C", Offset = "0x1B71C8C", VA = "0x1B71C8C")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x601254C")]
	[Address(RVA = "0x1B71C94", Offset = "0x1B71C94", VA = "0x1B71C94")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
