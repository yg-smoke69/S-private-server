using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025CC")]
public class UIApplyDeputyCaptainController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400E9CA")]
	[FieldOffset(Offset = "0x48")]
	private UIApplyDeputyCaptainView m_View;

	[Token(Token = "0x400E9CB")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x600DE2B")]
	[Address(RVA = "0x1E70894", Offset = "0x1E70894", VA = "0x1E70894")]
	public UIApplyDeputyCaptainController()
	{
	}

	[Token(Token = "0x600DE2C")]
	[Address(RVA = "0x1E7089C", Offset = "0x1E7089C", VA = "0x1E7089C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DE2D")]
	[Address(RVA = "0x1E70944", Offset = "0x1E70944", VA = "0x1E70944", Slot = "31")]
	public override string Rule()
	{
		return null;
	}

	[Token(Token = "0x600DE2E")]
	[Address(RVA = "0x1E709E8", Offset = "0x1E709E8", VA = "0x1E709E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DE2F")]
	[Address(RVA = "0x1E70C18", Offset = "0x1E70C18", VA = "0x1E70C18", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600DE30")]
	[Address(RVA = "0x1E70D48", Offset = "0x1E70D48", VA = "0x1E70D48", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600DE31")]
	[Address(RVA = "0x1E70DAC", Offset = "0x1E70DAC", VA = "0x1E70DAC", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600DE32")]
	[Address(RVA = "0x1E71024", Offset = "0x1E71024", VA = "0x1E71024")]
	private void OnApplyBtnClick()
	{
	}

	[Token(Token = "0x600DE33")]
	[Address(RVA = "0x1E7109C", Offset = "0x1E7109C", VA = "0x1E7109C")]
	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}

	[Token(Token = "0x600DE34")]
	[Address(RVA = "0x1E710A4", Offset = "0x1E710A4", VA = "0x1E710A4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DE35")]
	[Address(RVA = "0x1E710AC", Offset = "0x1E710AC", VA = "0x1E710AC")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
