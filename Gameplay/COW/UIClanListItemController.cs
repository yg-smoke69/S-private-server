using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002549")]
public class UIClanListItemController : UIEasyListItemController
{
	[Token(Token = "0x400E707")]
	[FieldOffset(Offset = "0x38")]
	private UIClanListItemView m_View;

	[Token(Token = "0x400E708")]
	[FieldOffset(Offset = "0x3C")]
	private ClanInfo m_ClanInfo;

	[Token(Token = "0x400E709")]
	[FieldOffset(Offset = "0x40")]
	private EClanSearchLabelType m_SearchLabelType;

	[Token(Token = "0x600D90C")]
	[Address(RVA = "0x2B30110", Offset = "0x2B30110", VA = "0x2B30110")]
	public UIClanListItemController()
	{
	}

	[Token(Token = "0x600D90D")]
	[Address(RVA = "0x2B30118", Offset = "0x2B30118", VA = "0x2B30118")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D90E")]
	[Address(RVA = "0x2B301BC", Offset = "0x2B301BC", VA = "0x2B301BC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D90F")]
	[Address(RVA = "0x2B30318", Offset = "0x2B30318", VA = "0x2B30318", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D910")]
	[Address(RVA = "0x2B30E18", Offset = "0x2B30E18", VA = "0x2B30E18")]
	public void ChangeLabelType(EClanSearchLabelType type)
	{
	}

	[Token(Token = "0x600D911")]
	[Address(RVA = "0x2B31674", Offset = "0x2B31674", VA = "0x2B31674")]
	public void OnBtnClanJoin()
	{
	}

	[Token(Token = "0x600D912")]
	[Address(RVA = "0x2B3121C", Offset = "0x2B3121C", VA = "0x2B3121C")]
	public void UpdateRank(int rank)
	{
	}

	[Token(Token = "0x600D913")]
	[Address(RVA = "0x2B31438", Offset = "0x2B31438", VA = "0x2B31438")]
	public void UpdateCSRank(int rank)
	{
	}

	[Token(Token = "0x600D914")]
	[Address(RVA = "0x2B31C30", Offset = "0x2B31C30", VA = "0x2B31C30")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
