using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200256B")]
public class UIClanWarTeamBoxItemController : UIBaseController
{
	[Token(Token = "0x400E79D")]
	[FieldOffset(Offset = "0x28")]
	private UIClanWarTeamBoxItemView m_View;

	[Token(Token = "0x400E79E")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400E79F")]
	[FieldOffset(Offset = "0x30")]
	private UIModelClan.BoxStatus m_Status;

	[Token(Token = "0x400E7A0")]
	[FieldOffset(Offset = "0x34")]
	private uint m_Level;

	[Token(Token = "0x400E7A1")]
	[FieldOffset(Offset = "0x38")]
	private EClan.ClanWarPhaseType m_Stage;

	[Token(Token = "0x600DA8B")]
	[Address(RVA = "0x290CEC0", Offset = "0x290CEC0", VA = "0x290CEC0")]
	public UIClanWarTeamBoxItemController()
	{
	}

	[Token(Token = "0x600DA8C")]
	[Address(RVA = "0x290CF44", Offset = "0x290CF44", VA = "0x290CF44")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DA8D")]
	[Address(RVA = "0x290CFE8", Offset = "0x290CFE8", VA = "0x290CFE8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DA8E")]
	[Address(RVA = "0x290B424", Offset = "0x290B424", VA = "0x290B424")]
	public void SetLevel(uint level)
	{
	}

	[Token(Token = "0x600DA8F")]
	[Address(RVA = "0x290B484", Offset = "0x290B484", VA = "0x290B484")]
	public void SetStatus(UIModelClan.BoxStatus status)
	{
	}

	[Token(Token = "0x600DA90")]
	[Address(RVA = "0x290B61C", Offset = "0x290B61C", VA = "0x290B61C")]
	public void SetBound(uint bound)
	{
	}

	[Token(Token = "0x600DA91")]
	[Address(RVA = "0x290D1B4", Offset = "0x290D1B4", VA = "0x290D1B4")]
	public UIModelClan.BoxStatus GetStatus()
	{
		return default(UIModelClan.BoxStatus);
	}

	[Token(Token = "0x600DA92")]
	[Address(RVA = "0x290D20C", Offset = "0x290D20C", VA = "0x290D20C")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600DA93")]
	[Address(RVA = "0x290D3EC", Offset = "0x290D3EC", VA = "0x290D3EC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
