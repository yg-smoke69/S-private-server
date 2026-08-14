using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002032")]
public class UIClanMatchResultPopupController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400CA10")]
	[FieldOffset(Offset = "0x48")]
	private UIClanMatchResultPopupView m_View;

	[Token(Token = "0x400CA11")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x600A367")]
	[Address(RVA = "0x2B3AC4C", Offset = "0x2B3AC4C", VA = "0x2B3AC4C")]
	public UIClanMatchResultPopupController()
	{
	}

	[Token(Token = "0x600A368")]
	[Address(RVA = "0x2B3AC54", Offset = "0x2B3AC54", VA = "0x2B3AC54")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A369")]
	[Address(RVA = "0x2B3ACFC", Offset = "0x2B3ACFC", VA = "0x2B3ACFC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A36A")]
	[Address(RVA = "0x2B3AEEC", Offset = "0x2B3AEEC", VA = "0x2B3AEEC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600A36B")]
	[Address(RVA = "0x2B3AF74", Offset = "0x2B3AF74", VA = "0x2B3AF74")]
	public void SetResultAttachData(FakeSubmitRes clanMatchResult)
	{
	}

	[Token(Token = "0x600A36C")]
	[Address(RVA = "0x2B3B458", Offset = "0x2B3B458", VA = "0x2B3B458")]
	private void SetClanInfo()
	{
	}

	[Token(Token = "0x600A36D")]
	[Address(RVA = "0x2B3B934", Offset = "0x2B3B934", VA = "0x2B3B934")]
	private void RefreshCupIcon(FakeSubmitRes clanMatchResult)
	{
	}

	[Token(Token = "0x600A36E")]
	[Address(RVA = "0x2B3BE44", Offset = "0x2B3BE44", VA = "0x2B3BE44", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600A36F")]
	[Address(RVA = "0x2B3C038", Offset = "0x2B3C038", VA = "0x2B3C038", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A370")]
	[Address(RVA = "0x2B3C1C8", Offset = "0x2B3C1C8", VA = "0x2B3C1C8", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A371")]
	[Address(RVA = "0x2B3C25C", Offset = "0x2B3C25C", VA = "0x2B3C25C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A372")]
	[Address(RVA = "0x2B3C264", Offset = "0x2B3C264", VA = "0x2B3C264")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600A373")]
	[Address(RVA = "0x2B3C26C", Offset = "0x2B3C26C", VA = "0x2B3C26C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
