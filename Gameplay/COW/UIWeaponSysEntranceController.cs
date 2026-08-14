using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C1B")]
internal class UIWeaponSysEntranceController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x4010D6A")]
	[FieldOffset(Offset = "0x48")]
	private UIWeaponSysEntranceView m_View;

	[Token(Token = "0x4010D6B")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelWeaponSkinUpgrader m_ModelWsu;

	[Token(Token = "0x4010D6C")]
	[FieldOffset(Offset = "0x50")]
	private uint m_VfxDelayCallId;

	[Token(Token = "0x601258C")]
	[Address(RVA = "0x1B7A854", Offset = "0x1B7A854", VA = "0x1B7A854")]
	public UIWeaponSysEntranceController()
	{
	}

	[Token(Token = "0x601258D")]
	[Address(RVA = "0x1B7A85C", Offset = "0x1B7A85C", VA = "0x1B7A85C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601258E")]
	[Address(RVA = "0x1B7A904", Offset = "0x1B7A904", VA = "0x1B7A904", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601258F")]
	[Address(RVA = "0x1B7B048", Offset = "0x1B7B048", VA = "0x1B7B048", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012590")]
	[Address(RVA = "0x1B7B1EC", Offset = "0x1B7B1EC", VA = "0x1B7B1EC")]
	private void OnWeaponSkinUpgraderClick()
	{
	}

	[Token(Token = "0x6012591")]
	[Address(RVA = "0x1B7B5E4", Offset = "0x1B7B5E4", VA = "0x1B7B5E4")]
	private void GotoUpgrader()
	{
	}

	[Token(Token = "0x6012592")]
	[Address(RVA = "0x1B7B800", Offset = "0x1B7B800", VA = "0x1B7B800")]
	private void GotoSkinLobby()
	{
	}

	[Token(Token = "0x6012593")]
	[Address(RVA = "0x1B7B51C", Offset = "0x1B7B51C", VA = "0x1B7B51C")]
	private void StopVfx()
	{
	}

	[Token(Token = "0x6012594")]
	[Address(RVA = "0x1B7B9C8", Offset = "0x1B7B9C8", VA = "0x1B7B9C8")]
	private void OnWeaponSkiEnternClick()
	{
	}

	[Token(Token = "0x6012595")]
	[Address(RVA = "0x1B7BB60", Offset = "0x1B7BB60", VA = "0x1B7BB60", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6012596")]
	[Address(RVA = "0x1B7AD00", Offset = "0x1B7AD00", VA = "0x1B7AD00")]
	private void RefreshWsuRedPoint()
	{
	}

	[Token(Token = "0x6012597")]
	[Address(RVA = "0x1B7BC2C", Offset = "0x1B7BC2C", VA = "0x1B7BC2C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6012598")]
	[Address(RVA = "0x1B7BCC0", Offset = "0x1B7BCC0", VA = "0x1B7BCC0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012599")]
	[Address(RVA = "0x1B7BCC8", Offset = "0x1B7BCC8", VA = "0x1B7BCC8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
