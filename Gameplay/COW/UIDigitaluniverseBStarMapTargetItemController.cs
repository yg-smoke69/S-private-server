using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F04")]
internal class UIDigitaluniverseBStarMapTargetItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x2001F05")]
	private sealed class _003CSetViewData_003Ec__AnonStorey0
	{
		[Token(Token = "0x400C33D")]
		[FieldOffset(Offset = "0x8")]
		internal DigitaluniverseBStarCraftTargetDesc desc;

		[Token(Token = "0x60097D8")]
		[Address(RVA = "0x2F19CA0", Offset = "0x2F19CA0", VA = "0x2F19CA0")]
		public _003CSetViewData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60097D9")]
		[Address(RVA = "0x2F1A050", Offset = "0x2F1A050", VA = "0x2F1A050")]
		internal bool _003C_003Em__0(uint value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400C339")]
	[FieldOffset(Offset = "0x28")]
	private DigitaluniverseBStarCraftTargetDesc m_Desc;

	[Token(Token = "0x400C33A")]
	[FieldOffset(Offset = "0x2C")]
	private UIDigitaluniverseBStarMapTargetItemView m_View;

	[Token(Token = "0x400C33B")]
	[FieldOffset(Offset = "0x30")]
	private UIStandardItemMiniController m_UIStandardItemMiniController;

	[Token(Token = "0x400C33C")]
	[FieldOffset(Offset = "0x34")]
	private UIModelDigitaluniverseB m_Model;

	[Token(Token = "0x60097D0")]
	[Address(RVA = "0x2F198F8", Offset = "0x2F198F8", VA = "0x2F198F8")]
	public UIDigitaluniverseBStarMapTargetItemController()
	{
	}

	[Token(Token = "0x60097D1")]
	[Address(RVA = "0x2F1997C", Offset = "0x2F1997C", VA = "0x2F1997C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60097D2")]
	[Address(RVA = "0x2F19A24", Offset = "0x2F19A24", VA = "0x2F19A24", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60097D3")]
	[Address(RVA = "0x2F131C4", Offset = "0x2F131C4", VA = "0x2F131C4")]
	public void SetViewData(DigitaluniverseBStarCraftTargetDesc desc, int playersNum)
	{
	}

	[Token(Token = "0x60097D4")]
	[Address(RVA = "0x2F19CA8", Offset = "0x2F19CA8", VA = "0x2F19CA8")]
	private void OnBtnClaimClick()
	{
	}

	[Token(Token = "0x60097D5")]
	[Address(RVA = "0x2F19D28", Offset = "0x2F19D28", VA = "0x2F19D28", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60097D6")]
	[Address(RVA = "0x2F19FB4", Offset = "0x2F19FB4", VA = "0x2F19FB4", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60097D7")]
	[Address(RVA = "0x2F1A048", Offset = "0x2F1A048", VA = "0x2F1A048")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
