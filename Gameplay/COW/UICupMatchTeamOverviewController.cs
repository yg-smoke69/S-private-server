using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200208C")]
public class UICupMatchTeamOverviewController : UIBaseController, _Attribute
{
	[Token(Token = "0x400CC0A")]
	[FieldOffset(Offset = "0x28")]
	private UICupMatchTeamOverviewView m_View;

	[Token(Token = "0x400CC0B")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CC0C")]
	[FieldOffset(Offset = "0x30")]
	private bool m_CanEdit;

	[Token(Token = "0x400CC0D")]
	[FieldOffset(Offset = "0x34")]
	private int m_CupMatchKey;

	[Token(Token = "0x600A77F")]
	[Address(RVA = "0x11DE980", Offset = "0x11DE980", VA = "0x11DE980")]
	public UICupMatchTeamOverviewController()
	{
	}

	[Token(Token = "0x600A780")]
	[Address(RVA = "0x11DEA04", Offset = "0x11DEA04", VA = "0x11DEA04")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A781")]
	[Address(RVA = "0x11DEAAC", Offset = "0x11DEAAC", VA = "0x11DEAAC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A782")]
	[Address(RVA = "0x11DEE5C", Offset = "0x11DEE5C", VA = "0x11DEE5C")]
	public void SetData(CupTeamInfo teamInfo, int key, bool showEditButton = false)
	{
	}

	[Token(Token = "0x600A783")]
	[Address(RVA = "0x11DF178", Offset = "0x11DF178", VA = "0x11DF178")]
	public void SetNationFlag(UISprite flagSprite, CupTeamInfo teamInfo)
	{
	}

	[Token(Token = "0x600A784")]
	[Address(RVA = "0x11DF4BC", Offset = "0x11DF4BC", VA = "0x11DF4BC")]
	private void EditInfo()
	{
	}

	[Token(Token = "0x600A785")]
	[Address(RVA = "0x11DF5F4", Offset = "0x11DF5F4", VA = "0x11DF5F4")]
	private void OnTipsBtnClick()
	{
	}

	[Token(Token = "0x600A786")]
	[Address(RVA = "0x11DF83C", Offset = "0x11DF83C", VA = "0x11DF83C", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A787")]
	[Address(RVA = "0x11DFA98", Offset = "0x11DFA98", VA = "0x11DFA98", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A788")]
	[Address(RVA = "0x11DFB2C", Offset = "0x11DFB2C", VA = "0x11DFB2C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
