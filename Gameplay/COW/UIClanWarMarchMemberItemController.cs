using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200255B")]
public class UIClanWarMarchMemberItemController : UIBaseController
{
	[Token(Token = "0x400E758")]
	[FieldOffset(Offset = "0x28")]
	private UIClanWarMarchMemberItemView m_View;

	[Token(Token = "0x400E759")]
	[FieldOffset(Offset = "0x2C")]
	private UIBaseProfileInfoController m_BaseProfileUI;

	[Token(Token = "0x400E75A")]
	[FieldOffset(Offset = "0x30")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400E75B")]
	[FieldOffset(Offset = "0x38")]
	private ulong m_AccountId;

	[Token(Token = "0x400E75C")]
	[FieldOffset(Offset = "0x40")]
	private uint m_DelayCallID;

	[Token(Token = "0x600D9E6")]
	[Address(RVA = "0x28F53D4", Offset = "0x28F53D4", VA = "0x28F53D4")]
	public UIClanWarMarchMemberItemController()
	{
	}

	[Token(Token = "0x600D9E7")]
	[Address(RVA = "0x28F5458", Offset = "0x28F5458", VA = "0x28F5458")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D9E8")]
	[Address(RVA = "0x28F54FC", Offset = "0x28F54FC", VA = "0x28F54FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D9E9")]
	[Address(RVA = "0x28F5910", Offset = "0x28F5910", VA = "0x28F5910", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D9EA")]
	[Address(RVA = "0x28F56A8", Offset = "0x28F56A8", VA = "0x28F56A8")]
	private void InitView()
	{
	}

	[Token(Token = "0x600D9EB")]
	[Address(RVA = "0x28F5A24", Offset = "0x28F5A24", VA = "0x28F5A24")]
	public bool SetProfile(ClanWarTeamMemberInfo memberInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600D9EC")]
	[Address(RVA = "0x28F5E7C", Offset = "0x28F5E7C", VA = "0x28F5E7C")]
	public void SetNewMemberEffect(bool isNew)
	{
	}

	[Token(Token = "0x600D9ED")]
	[Address(RVA = "0x28F6138", Offset = "0x28F6138", VA = "0x28F6138")]
	private void OnProfileClick()
	{
	}

	[Token(Token = "0x600D9EE")]
	[Address(RVA = "0x28F6C38", Offset = "0x28F6C38", VA = "0x28F6C38")]
	private void OnPopMenuClick(object obj)
	{
	}

	[Token(Token = "0x600D9EF")]
	[Address(RVA = "0x28F6F48", Offset = "0x28F6F48", VA = "0x28F6F48")]
	private void _003CSetNewMemberEffect_003Em__0()
	{
	}

	[Token(Token = "0x600D9F0")]
	[Address(RVA = "0x28F6FE4", Offset = "0x28F6FE4", VA = "0x28F6FE4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D9F1")]
	[Address(RVA = "0x28F6FEC", Offset = "0x28F6FEC", VA = "0x28F6FEC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
