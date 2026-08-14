using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001FA4")]
public class UIHudArmsRaceMatchResultItemController : UIEasyListItemController
{
	[Token(Token = "0x400C678")]
	[FieldOffset(Offset = "0x38")]
	private TeammateStats m_Data;

	[Token(Token = "0x400C679")]
	[FieldOffset(Offset = "0x3C")]
	private UIHudArmsRaceMatchResultItemView m_View;

	[Token(Token = "0x400C67A")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsLocal;

	[Token(Token = "0x400C67B")]
	[FieldOffset(Offset = "0x48")]
	private ulong m_LocalAccountID;

	[Token(Token = "0x400C67C")]
	private const uint SELFNAMECOLOR = 4157231103u;

	[Token(Token = "0x6009DB5")]
	[Address(RVA = "0x1705B30", Offset = "0x1705B30", VA = "0x1705B30")]
	public UIHudArmsRaceMatchResultItemController()
	{
	}

	[Token(Token = "0x6009DB6")]
	[Address(RVA = "0x1705B38", Offset = "0x1705B38", VA = "0x1705B38")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009DB7")]
	[Address(RVA = "0x1705BE0", Offset = "0x1705BE0", VA = "0x1705BE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009DB8")]
	[Address(RVA = "0x1705C9C", Offset = "0x1705C9C", VA = "0x1705C9C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6009DB9")]
	[Address(RVA = "0x1705DF4", Offset = "0x1705DF4", VA = "0x1705DF4")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6009DBA")]
	[Address(RVA = "0x1705A28", Offset = "0x1705A28", VA = "0x1705A28")]
	public void SetLocalID(ulong localAccountID)
	{
	}

	[Token(Token = "0x6009DBB")]
	[Address(RVA = "0x1706070", Offset = "0x1706070", VA = "0x1706070")]
	private void SetNameIcon()
	{
	}

	[Token(Token = "0x6009DBC")]
	[Address(RVA = "0x17063C0", Offset = "0x17063C0", VA = "0x17063C0")]
	private void SetFriendBtnState()
	{
	}

	[Token(Token = "0x6009DBD")]
	[Address(RVA = "0x1706630", Offset = "0x1706630", VA = "0x1706630")]
	private void SetBGState()
	{
	}

	[Token(Token = "0x6009DBE")]
	[Address(RVA = "0x17067DC", Offset = "0x17067DC", VA = "0x17067DC")]
	private void OnAddFriend()
	{
	}

	[Token(Token = "0x6009DBF")]
	[Address(RVA = "0x17069DC", Offset = "0x17069DC", VA = "0x17069DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
