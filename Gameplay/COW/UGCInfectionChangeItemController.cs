using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200248C")]
internal class UGCInfectionChangeItemController : UIBaseController
{
	[Token(Token = "0x200248D")]
	public class UGCInfectionChangeItemData
	{
		[Token(Token = "0x400E2A2")]
		[FieldOffset(Offset = "0x8")]
		public uint ItemID;

		[Token(Token = "0x400E2A3")]
		[FieldOffset(Offset = "0xC")]
		public MDCLINGOINF Type;

		[Token(Token = "0x600D0C8")]
		[Address(RVA = "0x29F1970", Offset = "0x29F1970", VA = "0x29F1970")]
		public UGCInfectionChangeItemData()
		{
		}
	}

	[Token(Token = "0x400E2A0")]
	[FieldOffset(Offset = "0x28")]
	private UGCInfectionChangeItemView m_View;

	[Token(Token = "0x400E2A1")]
	[FieldOffset(Offset = "0x2C")]
	private UGCInfectionChangeItemData m_Data;

	[Token(Token = "0x600D0BF")]
	[Address(RVA = "0x29F0C14", Offset = "0x29F0C14", VA = "0x29F0C14")]
	public UGCInfectionChangeItemController()
	{
	}

	[Token(Token = "0x600D0C0")]
	[Address(RVA = "0x29F0C98", Offset = "0x29F0C98", VA = "0x29F0C98")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D0C1")]
	[Address(RVA = "0x29F0D40", Offset = "0x29F0D40", VA = "0x29F0D40", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D0C2")]
	[Address(RVA = "0x29F0ED4", Offset = "0x29F0ED4", VA = "0x29F0ED4")]
	public void SetData(UGCInfectionChangeItemData data)
	{
	}

	[Token(Token = "0x600D0C3")]
	[Address(RVA = "0x29F1488", Offset = "0x29F1488", VA = "0x29F1488")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x600D0C4")]
	[Address(RVA = "0x29F1520", Offset = "0x29F1520", VA = "0x29F1520")]
	public uint GetItemID()
	{
		return default(uint);
	}

	[Token(Token = "0x600D0C5")]
	[Address(RVA = "0x29F158C", Offset = "0x29F158C", VA = "0x29F158C")]
	public void OnButtonClicked()
	{
	}

	[Token(Token = "0x600D0C6")]
	[Address(RVA = "0x29F1878", Offset = "0x29F1878", VA = "0x29F1878")]
	private bool _003CSetData_003Em__0(CSVBaseData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600D0C7")]
	[Address(RVA = "0x29F1968", Offset = "0x29F1968", VA = "0x29F1968")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
