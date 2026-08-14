using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200255E")]
public class UIClanWarMarchTeamReadyItemController : UIBaseController
{
	[Token(Token = "0x400E763")]
	[FieldOffset(Offset = "0x28")]
	private UIClanWarMarchTeamReadyItemView m_View;

	[Token(Token = "0x400E764")]
	[FieldOffset(Offset = "0x2C")]
	private UIBaseProfileInfoController m_BaseProfileUI;

	[Token(Token = "0x400E765")]
	[FieldOffset(Offset = "0x30")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400E766")]
	[FieldOffset(Offset = "0x38")]
	private ulong m_AccountId;

	[Token(Token = "0x600DA17")]
	[Address(RVA = "0x28FCF68", Offset = "0x28FCF68", VA = "0x28FCF68")]
	public UIClanWarMarchTeamReadyItemController()
	{
	}

	[Token(Token = "0x600DA18")]
	[Address(RVA = "0x28FCFEC", Offset = "0x28FCFEC", VA = "0x28FCFEC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DA19")]
	[Address(RVA = "0x28FD090", Offset = "0x28FD090", VA = "0x28FD090", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DA1A")]
	[Address(RVA = "0x28FD254", Offset = "0x28FD254", VA = "0x28FD254")]
	public void SetProfile(ClanWarTeamMemberInfo memberInfo)
	{
	}

	[Token(Token = "0x600DA1B")]
	[Address(RVA = "0x28FD518", Offset = "0x28FD518", VA = "0x28FD518")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
