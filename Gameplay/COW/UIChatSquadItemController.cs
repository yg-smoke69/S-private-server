using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002517")]
public class UIChatSquadItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400E617")]
	[FieldOffset(Offset = "0x38")]
	private UIChatSquadItemView m_View;

	[Token(Token = "0x400E618")]
	[FieldOffset(Offset = "0x3C")]
	private ChatChannelInfo m_Data;

	[Token(Token = "0x400E619")]
	[FieldOffset(Offset = "0x40")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400E61A")]
	[FieldOffset(Offset = "0x44")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x600D75F")]
	[Address(RVA = "0x207D43C", Offset = "0x207D43C", VA = "0x207D43C")]
	public UIChatSquadItemController()
	{
	}

	[Token(Token = "0x600D760")]
	[Address(RVA = "0x207D444", Offset = "0x207D444", VA = "0x207D444")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D761")]
	[Address(RVA = "0x207D4EC", Offset = "0x207D4EC", VA = "0x207D4EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D762")]
	[Address(RVA = "0x207D764", Offset = "0x207D764", VA = "0x207D764", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D763")]
	[Address(RVA = "0x207D86C", Offset = "0x207D86C", VA = "0x207D86C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D764")]
	[Address(RVA = "0x207DE9C", Offset = "0x207DE9C", VA = "0x207DE9C", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D765")]
	[Address(RVA = "0x207E050", Offset = "0x207E050", VA = "0x207E050", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600D766")]
	[Address(RVA = "0x207E0EC", Offset = "0x207E0EC", VA = "0x207E0EC", Slot = "37")]
	private void COW_002EITipsDelegate_002EOnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x600D767")]
	[Address(RVA = "0x207DC7C", Offset = "0x207DC7C", VA = "0x207DC7C")]
	private void RefreshUnreadTips()
	{
	}

	[Token(Token = "0x600D768")]
	[Address(RVA = "0x207E178", Offset = "0x207E178", VA = "0x207E178")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D769")]
	[Address(RVA = "0x207E180", Offset = "0x207E180", VA = "0x207E180")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600D76A")]
	[Address(RVA = "0x207E188", Offset = "0x207E188", VA = "0x207E188")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D76B")]
	[Address(RVA = "0x207E190", Offset = "0x207E190", VA = "0x207E190")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
