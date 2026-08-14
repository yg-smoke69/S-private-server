using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002612")]
public class UIFastSendGiftItemController : UIMallItemBaseController
{
	[Token(Token = "0x400EB02")]
	[FieldOffset(Offset = "0x12C")]
	private UIFastSendGiftItemView m_View;

	[Token(Token = "0x400EB03")]
	[FieldOffset(Offset = "0x130")]
	private GiftItem m_GiftItem;

	[Token(Token = "0x400EB04")]
	[FieldOffset(Offset = "0x134")]
	private float m_ItemSize;

	[Token(Token = "0x400EB05")]
	[FieldOffset(Offset = "0x138")]
	private bool m_IsInGame;

	[Token(Token = "0x400EB06")]
	[FieldOffset(Offset = "0x13C")]
	private EGiftItemType m_GiftItemType;

	[Token(Token = "0x600E145")]
	[Address(RVA = "0x1DBA5F8", Offset = "0x1DBA5F8", VA = "0x1DBA5F8")]
	public UIFastSendGiftItemController()
	{
	}

	[Token(Token = "0x600E146")]
	[Address(RVA = "0x1DBA600", Offset = "0x1DBA600", VA = "0x1DBA600")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E147")]
	[Address(RVA = "0x1DBA6A8", Offset = "0x1DBA6A8", VA = "0x1DBA6A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E148")]
	[Address(RVA = "0x1DBA914", Offset = "0x1DBA914", VA = "0x1DBA914", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E149")]
	[Address(RVA = "0x1DBAA48", Offset = "0x1DBAA48", VA = "0x1DBAA48", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600E14A")]
	[Address(RVA = "0x1DB8AF4", Offset = "0x1DB8AF4", VA = "0x1DB8AF4")]
	public void IsIngame(bool isIngame = false)
	{
	}

	[Token(Token = "0x600E14B")]
	[Address(RVA = "0x1DBAF60", Offset = "0x1DBAF60", VA = "0x1DBAF60")]
	public void RefreshData()
	{
	}

	[Token(Token = "0x600E14C")]
	[Address(RVA = "0x1DB8A90", Offset = "0x1DB8A90", VA = "0x1DB8A90")]
	public void AdjustScale(float size)
	{
	}

	[Token(Token = "0x600E14D")]
	[Address(RVA = "0x1DBB4FC", Offset = "0x1DBB4FC", VA = "0x1DBB4FC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600E14E")]
	[Address(RVA = "0x1DBA8A0", Offset = "0x1DBA8A0", VA = "0x1DBA8A0")]
	private void InitCommonWidget()
	{
	}

	[Token(Token = "0x600E14F")]
	[Address(RVA = "0x1DB8A30", Offset = "0x1DB8A30", VA = "0x1DB8A30")]
	public void SetGiftItemType(EGiftItemType type)
	{
	}

	[Token(Token = "0x600E150")]
	[Address(RVA = "0x1DBB668", Offset = "0x1DBB668", VA = "0x1DBB668")]
	private void OnFastSendGiftItemClick(object[] data)
	{
	}

	[Token(Token = "0x600E151")]
	[Address(RVA = "0x1DBB75C", Offset = "0x1DBB75C", VA = "0x1DBB75C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E152")]
	[Address(RVA = "0x1DBB764", Offset = "0x1DBB764", VA = "0x1DBB764")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600E153")]
	[Address(RVA = "0x1DBB76C", Offset = "0x1DBB76C", VA = "0x1DBB76C")]
	public new void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600E154")]
	[Address(RVA = "0x1DBB774", Offset = "0x1DBB774", VA = "0x1DBB774")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
