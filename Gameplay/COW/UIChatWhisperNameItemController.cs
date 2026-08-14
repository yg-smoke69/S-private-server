using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200251E")]
public class UIChatWhisperNameItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400E62F")]
	[FieldOffset(Offset = "0x38")]
	private UIChatWhisperNameItemView m_View;

	[Token(Token = "0x400E630")]
	[FieldOffset(Offset = "0x3C")]
	private ChatWhisperNameData m_WhisperData;

	[Token(Token = "0x600D798")]
	[Address(RVA = "0x2085B2C", Offset = "0x2085B2C", VA = "0x2085B2C")]
	public UIChatWhisperNameItemController()
	{
	}

	[Token(Token = "0x600D799")]
	[Address(RVA = "0x2085B34", Offset = "0x2085B34", VA = "0x2085B34")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D79A")]
	[Address(RVA = "0x2085BD8", Offset = "0x2085BD8", VA = "0x2085BD8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D79B")]
	[Address(RVA = "0x2085E68", Offset = "0x2085E68", VA = "0x2085E68")]
	private void OnDeleteClick()
	{
	}

	[Token(Token = "0x600D79C")]
	[Address(RVA = "0x2085FEC", Offset = "0x2085FEC", VA = "0x2085FEC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D79D")]
	[Address(RVA = "0x20860F4", Offset = "0x20860F4", VA = "0x20860F4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D79E")]
	[Address(RVA = "0x2086E8C", Offset = "0x2086E8C", VA = "0x2086E8C", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D79F")]
	[Address(RVA = "0x2087038", Offset = "0x2087038", VA = "0x2087038", Slot = "37")]
	private void COW_002EITipsDelegate_002EOnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x600D7A0")]
	[Address(RVA = "0x2086C5C", Offset = "0x2086C5C", VA = "0x2086C5C")]
	private void RefreshUnreadTips()
	{
	}

	[Token(Token = "0x600D7A1")]
	[Address(RVA = "0x20870C4", Offset = "0x20870C4", VA = "0x20870C4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D7A2")]
	[Address(RVA = "0x20870CC", Offset = "0x20870CC", VA = "0x20870CC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600D7A3")]
	[Address(RVA = "0x20870D4", Offset = "0x20870D4", VA = "0x20870D4")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
