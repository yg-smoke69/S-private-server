using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002502")]
public class UIBroadcastController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E5D3")]
	[FieldOffset(Offset = "0x28")]
	private UIBroadcastView m_View;

	[Token(Token = "0x400E5D4")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallId;

	[Token(Token = "0x600D66D")]
	[Address(RVA = "0x14484D4", Offset = "0x14484D4", VA = "0x14484D4")]
	public UIBroadcastController()
	{
	}

	[Token(Token = "0x600D66E")]
	[Address(RVA = "0x1448558", Offset = "0x1448558", VA = "0x1448558")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D66F")]
	[Address(RVA = "0x14485FC", Offset = "0x14485FC", VA = "0x14485FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D670")]
	[Address(RVA = "0x1448964", Offset = "0x1448964", VA = "0x1448964", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D671")]
	[Address(RVA = "0x1448B9C", Offset = "0x1448B9C", VA = "0x1448B9C")]
	private void OnNoticeClick()
	{
	}

	[Token(Token = "0x600D672")]
	[Address(RVA = "0x1448C28", Offset = "0x1448C28", VA = "0x1448C28")]
	private void OnCloseBroadCast(object[] data)
	{
	}

	[Token(Token = "0x600D673")]
	[Address(RVA = "0x1448CE0", Offset = "0x1448CE0", VA = "0x1448CE0", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D674")]
	[Address(RVA = "0x14490B0", Offset = "0x14490B0", VA = "0x14490B0", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D675")]
	[Address(RVA = "0x1449144", Offset = "0x1449144", VA = "0x1449144")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600D676")]
	[Address(RVA = "0x1449228", Offset = "0x1449228", VA = "0x1449228")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D677")]
	[Address(RVA = "0x1449230", Offset = "0x1449230", VA = "0x1449230")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
