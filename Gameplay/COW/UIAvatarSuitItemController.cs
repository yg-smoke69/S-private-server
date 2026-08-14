using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024D8")]
public class UIAvatarSuitItemController : UIEasyListItemController
{
	[Token(Token = "0x400E474")]
	[FieldOffset(Offset = "0x38")]
	private uint m_SuitID;

	[Token(Token = "0x400E475")]
	[FieldOffset(Offset = "0x3C")]
	private UIAvatarSuitListItemView m_View;

	[Token(Token = "0x400E476")]
	[FieldOffset(Offset = "0x40")]
	private bool isDefault;

	[Token(Token = "0x400E477")]
	[FieldOffset(Offset = "0x44")]
	private SuitDisplayData m_Data;

	[Token(Token = "0x400E478")]
	[FieldOffset(Offset = "0x48")]
	private AvatarSuitData m_SuitData;

	[Token(Token = "0x600D41A")]
	[Address(RVA = "0x2FA2050", Offset = "0x2FA2050", VA = "0x2FA2050")]
	public UIAvatarSuitItemController()
	{
	}

	[Token(Token = "0x600D41B")]
	[Address(RVA = "0x2FA2058", Offset = "0x2FA2058", VA = "0x2FA2058")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D41C")]
	[Address(RVA = "0x2FA20FC", Offset = "0x2FA20FC", VA = "0x2FA20FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D41D")]
	[Address(RVA = "0x2FA2398", Offset = "0x2FA2398", VA = "0x2FA2398", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D41E")]
	[Address(RVA = "0x2FA2AE0", Offset = "0x2FA2AE0", VA = "0x2FA2AE0")]
	public void OnItemClicked()
	{
	}

	[Token(Token = "0x600D41F")]
	[Address(RVA = "0x2FA2D78", Offset = "0x2FA2D78", VA = "0x2FA2D78")]
	private void OnEquipBtnClick()
	{
	}

	[Token(Token = "0x600D420")]
	[Address(RVA = "0x2FA324C", Offset = "0x2FA324C", VA = "0x2FA324C")]
	private void OnObtainBtnClick()
	{
	}

	[Token(Token = "0x600D421")]
	[Address(RVA = "0x2FA275C", Offset = "0x2FA275C", VA = "0x2FA275C")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x600D422")]
	[Address(RVA = "0x2FA32A0", Offset = "0x2FA32A0", VA = "0x2FA32A0")]
	private void ResetButtonState()
	{
	}

	[Token(Token = "0x600D423")]
	[Address(RVA = "0x2FA356C", Offset = "0x2FA356C", VA = "0x2FA356C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
