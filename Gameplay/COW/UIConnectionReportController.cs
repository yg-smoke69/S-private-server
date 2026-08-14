using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025A9")]
public class UIConnectionReportController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400E8E4")]
	[FieldOffset(Offset = "0x48")]
	private UIConnectionReportView m_View;

	[Token(Token = "0x400E8E5")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelConnectionReport m_Model;

	[Token(Token = "0x400E8E6")]
	[FieldOffset(Offset = "0x50")]
	private bool m_NeedShowState;

	[Token(Token = "0x1700114B")]
	private UIModelConnectionReport ConnectionModel
	{
		[Token(Token = "0x600DC66")]
		[Address(RVA = "0x1EBE75C", Offset = "0x1EBE75C", VA = "0x1EBE75C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600DC65")]
	[Address(RVA = "0x1EBE754", Offset = "0x1EBE754", VA = "0x1EBE754")]
	public UIConnectionReportController()
	{
	}

	[Token(Token = "0x600DC67")]
	[Address(RVA = "0x1EBE86C", Offset = "0x1EBE86C", VA = "0x1EBE86C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DC68")]
	[Address(RVA = "0x1EBE914", Offset = "0x1EBE914", VA = "0x1EBE914", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DC69")]
	[Address(RVA = "0x1EBEB68", Offset = "0x1EBEB68", VA = "0x1EBEB68", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DC6A")]
	[Address(RVA = "0x1EBEBF8", Offset = "0x1EBEBF8", VA = "0x1EBEBF8")]
	public void ShowInfo(string loc_key)
	{
	}

	[Token(Token = "0x600DC6B")]
	[Address(RVA = "0x1EBF004", Offset = "0x1EBF004", VA = "0x1EBF004")]
	private void OnSendBtnClick()
	{
	}

	[Token(Token = "0x600DC6C")]
	[Address(RVA = "0x1EBEDBC", Offset = "0x1EBEDBC", VA = "0x1EBEDBC")]
	private void RefreshButtonState()
	{
	}

	[Token(Token = "0x600DC6D")]
	[Address(RVA = "0x1EBF0A0", Offset = "0x1EBF0A0", VA = "0x1EBF0A0", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600DC6E")]
	[Address(RVA = "0x1EBF16C", Offset = "0x1EBF16C", VA = "0x1EBF16C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600DC6F")]
	[Address(RVA = "0x1EBF200", Offset = "0x1EBF200", VA = "0x1EBF200")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DC70")]
	[Address(RVA = "0x1EBF208", Offset = "0x1EBF208", VA = "0x1EBF208")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
